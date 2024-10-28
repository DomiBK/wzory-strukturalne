using System;
using System.Collections.Generic;

// Zadanie 1: Wzorzec Kompozyt - Struktura organizacyjna firmy
public interface IPracownik
{
    void WykonajPrace();
}

public class Pracownik : IPracownik
{
    public string Imie { get; private set; }

    public Pracownik(string imie)
    {
        Imie = imie;
    }

    public void WykonajPrace()
    {
        Console.WriteLine($"{Imie} wykonuje pracę.");
    }
}

public class Zespol : IPracownik
{
    private readonly List<IPracownik> _pracownicy = new List<IPracownik>();

    public void Dodaj(IPracownik pracownik)
    {
        _pracownicy.Add(pracownik);
    }

    public void Usun(IPracownik pracownik)
    {
        _pracownicy.Remove(pracownik);
    }

    public void WykonajPrace()
    {
        foreach (var pracownik in _pracownicy)
        {
            pracownik.WykonajPrace();
        }
    }
}

// Zadanie 2: Wzorzec Dekorator - Aplikacja kawiarni
public interface IKawa
{
    decimal Koszt();
}

public class KawaPodstawowa : IKawa
{
    public decimal Koszt()
    {
        return 5.0m; // podstawowa cena kawy
    }
}

public abstract class DodatekDoKawy : IKawa
{
    protected IKawa _kawa;

    public DodatekDoKawy(IKawa kawa)
    {
        _kawa = kawa;
    }

    public abstract decimal Koszt();
}

public class Mleko : DodatekDoKawy
{
    public Mleko(IKawa kawa) : base(kawa) { }

    public override decimal Koszt()
    {
        return _kawa.Koszt() + 1.5m; // koszt mleka
    }
}

public class Cukier : DodatekDoKawy
{
    public Cukier(IKawa kawa) : base(kawa) { }

    public override decimal Koszt()
    {
        return _kawa.Koszt() + 0.5m; // koszt cukru
    }
}

// Zadanie 3: Wzorzec Adapter - System audio
public interface IAudioOdtwarzacz
{
    void OdtworzPlik();
}

public class StaryOdtwarzacz
{
    public void Zagraj()
    {
        Console.WriteLine("Odtwarzanie pliku w starym systemie.");
    }
}

public class AudioAdapter : IAudioOdtwarzacz
{
    private readonly StaryOdtwarzacz _staryOdtwarzacz;

    public AudioAdapter(StaryOdtwarzacz staryOdtwarzacz)
    {
        _staryOdtwarzacz = staryOdtwarzacz;
    }

    public void OdtworzPlik()
    {
        _staryOdtwarzacz.Zagraj();
    }
}

// Program łączący wszystkie zadania
public class Program
{
    public static void Main()
    {
        // Zadanie 1: Kompozyt
        IPracownik pracownik1 = new Pracownik("Jan");
        IPracownik pracownik2 = new Pracownik("Anna");
        
        Zespol zespol1 = new Zespol();
        zespol1.Dodaj(pracownik1);
        zespol1.Dodaj(pracownik2);
        
        IPracownik pracownik3 = new Pracownik("Kasia");
        Zespol zespol2 = new Zespol();
        zespol2.Dodaj(zespol1);
        zespol2.Dodaj(pracownik3);
        
        Console.WriteLine("Struktura organizacyjna firmy:");
        zespol2.WykonajPrace();
        
        // Zadanie 2: Dekorator
        IKawa kawa = new KawaPodstawowa();
        kawa = new Mleko(kawa);
        kawa = new Cukier(kawa);
        Console.WriteLine($"\nCena kawy z mlekiem i cukrem: {kawa.Koszt()} PLN");
        
        // Zadanie 3: Adapter
        IAudioOdtwarzacz audioOdtwarzacz = new AudioAdapter(new StaryOdtwarzacz());
        Console.WriteLine("\nSystem audio:");
        audioOdtwarzacz.OdtworzPlik();
    }
}