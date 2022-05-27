# pcnet_zad1
Zadanie 1. z rektutacji do PCNET
OPIS KLAS

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
