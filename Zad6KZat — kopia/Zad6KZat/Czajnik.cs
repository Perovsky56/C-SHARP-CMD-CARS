using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Zad6KZat
{
    class Czajnik
    {
        private int iloscWody;
        private bool naPodstawce;

        public Czajnik()
        {
            iloscWody = 0;
            naPodstawce = true;
        }
        public void PokazMenu()
        {
            Console.Clear();
            string wybor;
            do
            {
                Console.WriteLine("MENU CZAJNIK:");
                Console.WriteLine(@"1. Pokaż obecny stan urządzenia.
2. Dolej wody.
3. Połóż czajnik na podstawkę.
4. Ściągnij czajnik z podstawki.
5. Zalej kubek wodą.
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
                        Console.WriteLine("Ile wody chcesz dolać? (w mililitrach)");
                        int temporary = Convert.ToInt32(Console.ReadLine());
                        while (temporary <= 0)
                        {
                            temporary = Convert.ToInt32(Console.ReadLine());
                        }
                        DolejWody(temporary);
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.Clear();
                        PolozNaPodstawke();
                        Console.ReadLine();
                        break;
                    case "4":
                        Console.Clear();
                        SciagnijZPodstawki();
                        Console.ReadLine();
                        break;
                    case "5":
                        Console.Clear();
                        ZalejKubek();
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
            string a;
            if (naPodstawce == true)
            {
                a = "znajduje się";
            }
            else
            {
                a = "nie znajduje się";
            };

            Console.WriteLine("Czajnik ma {0}ml wody, {1} na podstawce.", iloscWody, a);
        }
        private void DolejWody(int ileWody)
        {
            iloscWody += ileWody;
            if (iloscWody > 2000)
            {
                Console.WriteLine("Pojemność czajnika została przekroczona, woda została rozlana.");
                iloscWody = 2000;
            }
            else
            {
                Console.WriteLine("Dolano {0}ml do zawartości czajnika.", ileWody);
            }
        }
        private void PolozNaPodstawke()
        {
            Console.WriteLine("Umieszczono czajnik na podstawce.");
            naPodstawce = true;
        }
        private void SciagnijZPodstawki()
        {
            Console.WriteLine("Czajnik został zabrany z podstawki.");
            naPodstawce = false;
        }
        private void ZalejKubek()
        {
            if (naPodstawce == false && iloscWody > 0)
            {
                iloscWody -= 250;
                Console.WriteLine("Do kubka wlano wodę...");
                if (iloscWody > 250)
                {
                    Console.WriteLine("W czajniku pozostało {0}ml wody.", iloscWody);
                }
                if (iloscWody < 0)
                {
                    iloscWody = 0;
                    Console.WriteLine("Czajnik jest obecnie pusty.");
                }
            }
            else if (naPodstawce == true)
            {
                Console.WriteLine("Najpierw zdejmij czajnik z podstawki!");
            }
            else if (iloscWody <= 0)
            {
                Console.WriteLine("Z pustego i Salomon nie naleje.");
            }
        }
    }
}
