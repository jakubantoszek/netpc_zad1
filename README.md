# pcnet_zad1
Zadanie 1. z rektutacji do PCNET
**I OPIS KLAS**

KLASA Contact - zawiera informację na temat użytkownika, które są przesyłane do bazy. Funkcja printOnlyDate zamienia datę z czasem na samą datę, natomiast funkcja printCategory zamienia liczbę oznaczającą kategorię na jej nazwę.

KLASA Index - służy do logowania się na konto. W funkcji OnPost, która jest uruchamiana po podaniu maila i hasła w formularzy sprawdzamy czy w bazie znajduje się użytkownik o podanym mailu i haśle oraz zapisujemy informacje o zalogowaniu w sesji. Porównywanie haseł odbywa się poprzez porównanie hashów hasła (wygenerowanych przez funkcję hashCode)

KLASA Register - służy do rejestracji nowego użytkownika. Funkcja OnPost(), która ma przekazane informacje o użytkowniku zapisuje dane o nowym użytkowniku, przy czym hasło jest jeszcze hashowane w funkcji hashCode.

KLASA Index - zawiera stronę główną aplikacji. 
W części HTML znajduje się skrypt, który zmienia nagłówek strony, jeżeli użytkownik jest zalogowany. Reszta strony to tabela, która zwraca informacje o wszystkich użytkownikach (lub informację o ich braku w bazie). Jeżeli użytkownik jest zalogowany, wyświetlają się wszystkie informacje o użytkownikach (poza hasłem oczywiście).
W częsci C# przypisujemy do pól klasy bazę danych i listę kontaktów.

KLASA Startup - służy do początkowej konfiguracji aplikacji
KLASA Program - uruchamia aplikację (posiada funkcję Main)
KLASA Error - przekazuje użytkownikowi informacje o błędach
KLASA Privacy - zawiera informację o polityce prywatności

W pliku site.js znajdują się funckje do dynamicznej zmiany wyglądu strony przy formularzu (dodanie dodatkowych opcji dla kategorii Business i Other) oraz funkcje do walidacji formularza rejestracji.

**II WYKORZYSTANE BIBLIOTEKI**
W programie jest wiele bibliotek, głównie biblioteki System.* i ASP.NET Core'a / Microsoftu. Wszystkie wykorzystywane biblioteki podane są poniżej. Dwie ostatnie służą do generowania hashów.
System.ComponentModel.DataAnnotations
System.Collections.Generic
System.Threading.Tasks
System.Diagnostics
Microsoft.EntityFrameworkCore
Microsoft.Extensions.Configuration
Microsoft.Extensions.DependencyInjection
Microsoft.Extensions.Hosting
Microsoft.Extensions.Logging
Microsoft.AspNetCore.Mvc
Microsoft.AspNetCore.Mvc.RazorPages
Microsoft.AspNetCore.Http
Microsoft.AspNetCore.Cryptography.KeyDerivation
System.Security.Cryptography
