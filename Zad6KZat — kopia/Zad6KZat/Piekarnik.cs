using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Zad6KZat
{
    class Piekarnik
    {
        private bool czyWlaczony;
        private int temperaturaPieczenia;
        private string pieczonyObiekt;
        private bool czyObiektUpieczony;

        public Piekarnik()
        {
            czyWlaczony = false;
            temperaturaPieczenia = 0;
            pieczonyObiekt = "";
            czyObiektUpieczony = false;
        }

        public void PokazMenu()
        {
            Console.Clear();
            string wybor;
            do
            {
                Console.WriteLine("MENU PIEKARNIK:");
                Console.WriteLine(@"1. Pokaż obecny stan urządzenia.
2. Włącz piekarnik.
3. Wyłącz piekarnik.
4. Ustaw pokrętło temperatury.
5. Włóż obiekt do piekarnika.
6. Wyciągnij zawartość piekarnika.
7. Wróć do menu głównego."); // PODMENU
                wybor = Console.ReadLine();
                while (wybor != "1" && wybor != "2" && wybor != "3" && wybor != "4" && wybor != "5" && wybor != "6" && wybor != "7")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Błędny przycisk. Dozwolone od '1' do '7'.");
                    Thread.Sleep(1000);
                    Console.ResetColor();
                    wybor = Console.ReadLine();
                };
                switch (wybor)
                {
                    case "1":
                        Console.Clear();
                        PokazStan();
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.Clear();
                        Wlacz();
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.Clear();
                        Wylacz();
                        Console.ReadLine();
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Jaką temperaturę chcesz ustawić? (w stopniach Celsjusza - od 0 do 270)");
                        int temporary = Convert.ToInt32(Console.ReadLine());
                        while (temporary <= 0 || temporary > 270)
                        {
                            temporary = Convert.ToInt32(Console.ReadLine());
                        }
                        UstawTempPiecz(temporary);
                        Console.ReadLine();
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Co chcesz umieścić w piekarniku?");
                        string obiekt1 = Console.ReadLine();
                        Wloz(obiekt1);
                        Console.ReadLine();
                        break;
                    case "6":
                        Console.Clear();
                        Wyjmij();
                        Console.ReadLine();
                        break;
                    case "7":
                        Console.Clear();
                        Console.WriteLine("Trwa powrót do menu głównego...");
                        Thread.Sleep(1500);
                        break;
                }
                Console.Clear();
            } while (wybor != "7");
        }
        private void PokazStan()
        {
            string a, b;
            if (czyWlaczony == true)
            {
                a = "jest";
            }
            else
            {
                a = "nie jest";
            }
            if (pieczonyObiekt == "")
            {
                b = "W środku nie ma niczego.";
            }
            else
            {
                b = ("W środku znajduje się " + pieczonyObiekt + ".");
            }
            Console.WriteLine("Piekarnik {0} włączony, pokrętło temperatury jest ustawione na {1} stopni Celsjusza. {2}", a, temperaturaPieczenia, b);
        }
        private void Wlacz()
        {
            Console.WriteLine("Włączono piekarnik. Trwa pieczenie...");
            czyObiektUpieczony = true;
            czyWlaczony = true;
        }
        private void Wylacz()
        {
            Console.WriteLine("Wyłączono piekarnik.");
            czyWlaczony = false;
        }
        private void UstawTempPiecz(int temperatura)
        {
            temperaturaPieczenia = temperatura;
            Console.WriteLine("Ustawiono temperaturę pieczenia na {0} stopni Celsjusza.", temperaturaPieczenia);
        }
        private void Wloz(string obiektDoWlozenia)
        {
            pieczonyObiekt = obiektDoWlozenia;
            Console.WriteLine("Do piekarnika umieszczono: {0}.", pieczonyObiekt);
        }
        private void Wyjmij()
        {
            if (czyObiektUpieczony == true)
            {
                Console.WriteLine("Piekarnik został opróżniony. Pięknie pachnie...");
                pieczonyObiekt = "";
            }
            else
            {
                Console.WriteLine("Piekarnik został opróżniony.");
                pieczonyObiekt = "";
            }
            czyObiektUpieczony = false;
        }
    }
}
