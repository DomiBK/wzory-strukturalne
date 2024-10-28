# wzory-strukturalne
Przeanalizuj treść na temat podanych wzorców strukturalnych 

https://refactoring.guru/pl/design-patterns/adapter
https://refactoring.guru/pl/design-patterns/composite
https://refactoring.guru/pl/design-patterns/decorator

Zadanie 1: Wzorzec Kompozyt
Stwórz strukturę organizacyjną firmy, w której pracownicy mogą być zarówno indywidualnymi jednostkami (pracownicy), jak i grupami (zespoły). Każdy pracownik ma imię oraz funkcję wykonywania pracy. Zespół może zawierać zarówno pojedynczych pracowników, jak i inne zespoły.

Utwórz interfejs IPracownik, który będzie miał metodę WykonajPrace(). Utwórz klasę Pracownik, która implementuje ten interfejs, oraz klasę Zespol, która będzie mogła zawierać wiele obiektów IPracownik i też implementować ten interfejs.



Zadanie 2: Wzorzec Dekorator
Stwórz prostą aplikację kawiarni, w której klienci mogą zamawiać kawę i dodawać do niej dodatki, takie jak mleko i cukier. Każda kawa powinna mieć swoją cenę, a dodatki powinny ją zwiększać.

Utwórz interfejs IKawa z metodą Koszt(). Stwórz klasę KawaPodstawowa, która będzie implementować ten interfejs i reprezentować zwykłą kawę. Następnie stwórz dekoratory Mleko i Cukier, które będą zwiększać cenę kawy.



Zadanie 3: Wzorzec Adapter
Masz system, który korzysta z nowego interfejsu IAudioOdtwarzacz do odtwarzania plików audio, ale chcesz wykorzystać również stary system odtwarzania plików, który ma inny interfejs. Utwórz adapter, który pozwoli nowemu systemowi korzystać ze starego odtwarzacza.

Utwórz interfejs IAudioOdtwarzacz z metodą OdtworzPlik(). Następnie stwórz klasę StaryOdtwarzacz, która posiada metodę Zagraj(). Utwórz adapter, który przekształci wywołania metody OdtworzPlik() na Zagraj()
