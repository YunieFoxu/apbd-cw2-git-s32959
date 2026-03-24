# apbd-cw2-git-s32959
Sprzęt jest realizowany poprzez abstrakcyjną klasę Equipment 
po której dziedziczą klasy:
-Laptop
-VrHeadSet
-Camera
W klasie znajdują się wspólne cechy: id, nazwa, informacja o dostępności oraz cena wypożyczenia(na jej podstawie jest także wyliczany koszt dopłaty w przypadku spóźnienia) 
Każda z klas wykorzystuje bazowy konstruktor oraz nadpisaną metodę toString klasy Equipment.

Typy użytkownika są realizowane poprzez Enum UserType, w którym znajdują się także limity dla każdego typu użytkownika

Wypożyczenia są realizowane przy pomocy klasy Rental posiadającej: 
-id 
-obiekt klasy użytkownik  
-datę wypożyczenia ustawianą automatycznie na dzisiejszą datę
-datę spodziewanego dnia oddania(opcjonalne)
-datę faktycznego oddania(opcjonalne)

Logika wypożyczalni znajduje się w klasie Service i jest realizowane poprzez metody klasy.