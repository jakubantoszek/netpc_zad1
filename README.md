# pcnet_zad1
Zadanie 1. z rektutacji do PCNET

I. OPIS KLAS
KLASA Contact - zawiera informację na temat użytkownika, które są przesyłane do bazy. Funkcja printOnlyDate zamienia datę z czasem na samą datę, natomiast funkcja printCategory zamienia liczbę oznaczającą kategorię na jej nazwę.

KLASA Index - służy do logowania się na konto. W funkcji OnPost, która jest uruchamiana po podaniu maila i hasła w formularzy sprawdzamy czy w bazie znajduje się użytkownik o podanym mailu i haśle oraz zapisujemy informacje o zalogowaniu w sesji. Porównywanie haseł odbywa się poprzez porównanie hashów hasła (wygenerowanych przez funkcję hashCode)

KLASA Register - służy do rejestracji nowego użytkownika. Funkcja OnPost(), która ma przekazane informacje o użytkowniku zapisuje dane o nowym użytkowniku, przy czym hasło jest jeszcze hashowane w funkcji hashCode.

KLASA Index - zawiera stronę główną aplikacji. 
W części HTML znajduje się skrypt, który zmienia nagłówek strony, jeżeli użytkownik jest zalogowany. Reszta strony to tabela, która zwraca informacje o wszystkich użytkownikach (lub informację o ich braku w bazie). Jeżeli użytkownik jest zalogowany, wyświetlają się wszystkie informacje o użytkownikach (poza hasłem oczywiście).
W częsci C# przypisujemy do pól klasy bazę danych i listę kontaktów.

KLASA Logout - wylogowanie się z konta (usunięcie danych sesji)

KLASA Startup - służy do początkowej konfiguracji aplikacji
KLASA Program - uruchamia aplikację (posiada funkcję Main)
KLASA Error - przekazuje użytkownikowi informacje o błędach
KLASA Privacy - zawiera informację o polityce prywatności

W pliku site.js znajdują się funckje do dynamicznej zmiany wyglądu strony przy formularzu (dodanie dodatkowych opcji dla kategorii Business i Other) oraz funkcje do walidacji formularza rejestracji.

II. WYKORZYSTYWANE BIBLIOTEKI
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

III. SPOSÓB URUCHAMIANIA
Teoretycznie wystarczyłoby wrzucić wszystkie pliki poza plikiem .sln do folderu ContactList i uruchomienie pliku .sln, lecz trzeba wtedy samemu wgrać biblioteki. Dlatego, żeby GitHub pozwolił przesłać wszystkie pliki znajdują się one w pliku .zip. Wtedy bez jakichkolwiek zmian wystarczy wykonać poniższe kroki :
1) uruchomić plik .sln (Visual Studio 2019/2022)
2) zalecana jest wersja .NET Core 3.0, ponieważ przy jej użyciu tworzyłem aplikację
3) w pliku appsettings.json zmienić Server=...; na nazwę serwera SQL na komputerze, na którym będzie ten program uruchamiany
4) W konsoli do zarządzania pakietami najlepiej wpisać po kolei: remove-migration (usunięcie dotychczasów plików migracji) -> add-migration AddContactToDb (utworzenie migracji) -> update-database
5) Po wykonaniu kroku 4 powinna być utworzona baza danych Contacts, do której będą zapisywani użytkownicy.

Czasami mogą być błędy niezgodności wersji pakietów przy problemach najlepiej mieć wersje, które będą podane na samym dole pliku README. Po uruchomieniu powinno wszystko działać.
Zamiast pobierać .zip można też pobrać pliki JS, CSS, CS, CSHTML, JSON i zamienić/dodać je do szablonu w Visual Studio 2019/2022 - Aplikacja internetowa ASP.NET Core. Jednak myślę, że pobranie .zipa i wykonanie kroków tak ja podałem wyżej jest lepszym rozwiązaniem.

Wersje pakietów :
Microsoft.AspNetCore.Authentication.Cookies (2.2.0)
Microsoft.AspNetCore.Identity.EntityFrameworkCore (3.0.0)
Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation (3.0.0)
Microsoft.EntityFrameworkCore (3.0.0)
Microsoft.EntityFrameworkCore.SqlServer (3.0.0)
Microsoft.EntityFrameworkCore.Tools (3.0.0)
Newtonsoft.Json (13.0.1)
