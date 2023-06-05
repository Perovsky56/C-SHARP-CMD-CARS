using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Zad6KZat
{
    class Okap
    {
        private bool czyWyciagWlaczony;
        private bool czySwiatloWlaczone;

        public Okap()
        {
            czyWyciagWlaczony = false;
            czySwiatloWlaczone = false;
        }
        public void PokazMenu()
        {
            Console.Clear();
            string wybor;
            do
            {
                Console.WriteLine("MENU OKAP:");
                Console.WriteLine(@"1. Pokaż obecny stan urządzenia.
2. Włącz wyciąg powietrza.
3. Wyłącz wyciąg powietrza.
4. Włącz oświetlenie.
5. Wyłącz oświetlenie.
6. Wróć do menu głównego."); // PODMENU
                wybor = Console.ReadLine();
                while (wybor != "1" && wybor != "2" && wybor != "3" && wybor != "4" && wybor != "5" && wybor != "6")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Błędny przycisk. Dozwolone od '1' do '6'.");
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
                        WlaczWyciag();
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.Clear();
                        WylaczWyciag();
                        Console.ReadLine();
                        break;
                    case "4":
                        Console.Clear();
                        WlaczSwiatlo();
                        Console.ReadLine();
                        break;
                    case "5":
                        Console.Clear();
                        WylaczSwiatlo();
                        Console.ReadLine();
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("Trwa powrót do menu głównego...");
                        Thread.Sleep(1500);
                        break;
                }
                Console.Clear();
            } while (wybor != "6");
        }
        private void PokazStan()
        {
            string a, b;
            if (czyWyciagWlaczony == true)
            {
                a = "wyciąga powietrze z pomieszczenia";
            }
            else
            {
                a = "jest obecnie wyłączony";
            };

            if (czySwiatloWlaczone == true)
            {
                b = "włączone";
            }
            else
            {
                b = "wyłączone";
            };

            Console.WriteLine("Okap {0}, oświetlenie jest {1}.", a, b);
        }
        private void WlaczWyciag()
        {
            czyWyciagWlaczony = true;
            Console.WriteLine("Okap zaczyna wyciągać powietrze z pomieszczenia...");
        }
        private void WylaczWyciag()
        {
            czyWyciagWlaczony = false;
            Console.WriteLine("Wyciąg powietrza przez okap został wyłączony.");
        }
        private void WlaczSwiatlo()
        {
            czySwiatloWlaczone = true;
            Console.WriteLine("Światło w okapie włączone. W końcu widzisz, co gotujesz...");
        }
        private void WylaczSwiatlo()
        {
            czySwiatloWlaczone = false;
            Console.WriteLine("Światło w okapie wyłączone. Ciemno na tej kuchence...");
        }
    }
}
