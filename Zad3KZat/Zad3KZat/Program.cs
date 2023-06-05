using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zad3KZat
{
    class Telewizor
    {
        public bool czyWlaczony;
        public bool czyWyciszony;
        public int wybranyNrKanalu;

        public Telewizor()
        {
            czyWlaczony = false;
            czyWyciszony = false;
            wybranyNrKanalu = 1;
        }

        public void Pokaz()
        {
            Console.WriteLine(@"
    ┌─────────────────────────────────────────────────────────────────────────────────┐
    │                                                                                 │
    │  ┌───────────────────────────────────────────────────────────────────────────┐  │
    │  │                                                                           │  │
    │  │                                                                           │  │
    │  │                                                                           │  │
    │  │                                                                           │  │
    │  │                                                                           │  │
    │  │                                                                           │  │
    │  │                                                                           │  │
    │  │                                                                           │  │
    │  │                                                                           │  │
    │  │                                                                           │  │
    │  │                                                                           │  │
    │  │                                                                           │  │
    │  │                                                                           │  │
    │  │                                                                           │  │
    │  │                                                                           │  │
    │  │                                                                           │  │
    │  │                                                                           │  │
    │  │                                                                           │  │
    │  └───────────────────────────────────────────────────────────────────────────┘  │
    │                                    SZMELCUNG                                 xx │
    └─────────────────────────────────────┬────┬──────────────────────────────────────┘
                                          │    │
                                       ┌──┼────┼──┐
                                       └──────────┘");

        }
        public void PokazStan()
        {
            string a, b;
            if(czyWlaczony == true)
            {
                a = "włączony";
                if (czyWyciszony == true)
                {
                    b = "wyciszony";
                }
                else
                {
                    b = "odciszony";
                }
                Console.WriteLine("Telewizor jest {0} oraz {1}, nr kanału ustawiony na: {2}.", a, b, wybranyNrKanalu);
            } else
            {
                Console.WriteLine("Telewizor jest wyłączony.");
            }
           
        }
        public void WcisnijWlacznik()
        {
            if (czyWlaczony == true)
            {
                czyWlaczony = false;
                Console.WriteLine("Telewizor został wyłączony.");
            }
            else
            {
                czyWlaczony = true;
                Console.WriteLine("Telewizor został włączony.");
            };
        }
        public void WcisnijPrzyciskMute()
        {
            if (czyWlaczony == true)
            {
                if (czyWyciszony == true)
                {
                    Console.WriteLine("Telewizor został odciszony.");
                    czyWyciszony = false;
                }
                else
                {
                    Console.WriteLine("Telewizor został wyciszony.");
                    czyWyciszony = true;
                };
            } else
            {
                Console.WriteLine("Telewizor jest obecnie wyłączony.");
            }
        }
        public void WybierzKanal(int kanal)
        {
            if (czyWlaczony == true)
            {
                wybranyNrKanalu = kanal;
                Console.Write("Telewizor został przełączony na {0} kanał.", wybranyNrKanalu);
            } else
            {
                Console.Write("Telewizor jest obecnie wyłączony.");
            }
        }
    };

    class Czajnik
    {
        public int iloscWody;
        public bool czyPodlaczony;
        public bool naPodstawce;

        public Czajnik()
        {
            iloscWody = 0;
            czyPodlaczony = false;
            naPodstawce = true;
        }

        public void Pokaz()
        {
            Console.WriteLine(@"
         ┌──────────┐
    ┌──┬─┴──────────┴──┐
    └┼ │               ├──────┐
     └─┤  ┌────┐◄─  2l ├─────┼│
       │  │    │       │     ││
       │  │    │       │     ││
       │  │    │◄─1.5l │     ││
       │  │    │       │     ││
       │  │    │       │     ││
       │  │xxxx│◄─  1l │     ││
       │  │xxxx│       │     ││
       │  │xxxx│       │     ││
       │  │xxxx│◄─0.5l │     ││
       │  │xxxx│       ├─────┼│
       │  │xxxx│       ├──────┘
       │  └────┘       │
       │               │
     ┌─┼───────────────┼─┐
     └───────────────────┘");
        }
        public void PokazStan()
        {
            string a, b;
            if (naPodstawce == true)
            {
                a = "znajduje się";
            } else
            {
                a = "nie znajduje się";
            };
            if (czyPodlaczony == true)
            {
                b = "jest";
            } else
            {
                b = "nie jest";
            }
            Console.WriteLine("Czajnik ma {0}ml wody, {1} na podstawce i {2} podłączony do prądu.", iloscWody, a, b);
        }
        public void DolejWody(int ileWody)
        {
            iloscWody += ileWody;
            if (iloscWody > 2000)
            {
                Console.WriteLine("Pojemność czajnika została przekroczona, woda została rozlana.");
                iloscWody = 2000;
            } else
            {
                Console.WriteLine("Dolano {0}ml do zawartości czajnika.", ileWody);
            }
        }
        public void Podlacz()
        {
            czyPodlaczony = true;
            Console.WriteLine("Czajnik został podłączony do gniazdka.");
        }
        public void Odlacz()
        {
            czyPodlaczony = false;
            Console.WriteLine("Czajnik został odłączony od gniazdka.");
        }
        public void PolozNaPodstawke()
        {
            Console.WriteLine("Umieszczono czajnik na podstawce.");
            naPodstawce = true;
        }
        public void SciagnijZPodstawki()
        {
            Console.WriteLine("Czajnik został zabrany z podstawki.");
            naPodstawce = false;
        }
        public void ZalejKubek()
        {
            if(naPodstawce == false && iloscWody > 0)
            {
                Console.WriteLine("Do kubka wlano wodę.");
                iloscWody -= 250;
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
    };

    class Piekarnik
    {
        public bool czyWlaczony;
        public int temperaturaPieczenia;
        public string pieczonyObiekt;

        public Piekarnik()
        {
            czyWlaczony = false;
            temperaturaPieczenia = 0;
            pieczonyObiekt = "";
        }

        public void Pokaz()
        {
            Console.WriteLine
(@"
    ┌──────────────────────────────────────┐
    │                                      │
    │     xxx        ┌─────┐       xxx     │
    │    xxxxx       │12:30│      xxxxx    │
    │     xxx        └─────┘       xxx     │
    │                 ▼ ▼ ▲                │
    ├──────────────────────────────────────┤
    │                                      │
    │ ┌──────────────────────────────────┐ │
    │ └┼────────────────────────────────┼┘ │
    │  │                                │  │
    │  │                                │  │
    │  │                                │  │
    │  │                                │  │
    │  │                                │  │
    │  ├────────────────────────────────┤  │
    │  │┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼┼│  │
    │  ├────────────────────────────────┤  │
    │  │                                │  │
    │  │                                │  │
    │  │                                │  │
    │  │                                │  │
    │  └────────────────────────────────┘  │
    │                                      │
    │                                      │
    │                                      │
    └──────────────────────────────────────┘");
        }
        public void PokazStan()
        {
            string a, b;
            if (czyWlaczony == true)
            {
                a = "jest";
            } else
            {
                a = "nie jest";
            }
            if (pieczonyObiekt == "")
            {
                b = "W środku nie ma niczego.";
            } else
            {
                b = ("W środku znajduje się " + pieczonyObiekt + ".");
            }
            Console.WriteLine("Piekarnik {0} włączony, pokrętło temperatury jest ustawione na {1} stopni Celsjusza. {2}", a, temperaturaPieczenia, b);
        }
        public void Wlacz()
        {
            Console.WriteLine("Włączono piekarnik.");
            czyWlaczony = true;
        }
        public void Wylacz()
        {
            Console.WriteLine("Wyłączono piekarnik.");
            czyWlaczony = false;
        }
        public void UstawTempPiecz(int temperatura)
        {
            temperaturaPieczenia = temperatura;
            Console.WriteLine("Ustawiono temperaturę pieczenia na {0} stopni Celsjusza.", temperaturaPieczenia);
        }
        public void Wloz(string obiektDoWlozenia)
        {
            pieczonyObiekt = obiektDoWlozenia;
            Console.WriteLine("Do piekarnika umieszczono: {0}.", pieczonyObiekt);
        }
        public void Wyjmij()
        {
            Console.WriteLine("Piekarnik został opróżniony.");
            pieczonyObiekt = "";
        }
    };

    class Program
    {
        //PAWEŁ SIEMIGINOWSKI, s101450
        static void Przywitaj()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine
(@" +------------------------------------------+
 |  Projekt zadania nr 3 - PROGRAMOWANIE I  |
 |                                          |
 |                Sprzęt AGD                |
 |                                          |
 |   Autor: Paweł Siemiginowski, s101450    |
 +------------------------------------------+" + "\n");
            Console.ResetColor();
            Thread.Sleep(2000);
            Console.Clear();
        }
        static void ZakonczProgram()
        {
            Console.WriteLine("\nTrwa zamykanie programu...");
            Thread.Sleep(3000);
            System.Environment.Exit(1);
        }
        static void PokazMenuPoczat()
        {
            Console.WriteLine("Wybierz urządzenie, którym chcesz operować:");
            Console.WriteLine(@"1. Telewizor.
2. Czajnik.
3. Piekarnik.
4. Zakończ działanie programu.");

        }
        static string SprawdzOdpowiedz(string odp)
        {
            while (odp != "1" && odp != "2" && odp != "3" && odp != "4")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Błędny przycisk. Dozwolone: '1', '2', '3' lub '4'.");
                Thread.Sleep(1000);
                Console.ResetColor();
                odp = Console.ReadLine();
            };
            return odp;
        }
        static string WybierzMenuPoczat()
        {
            string odp = Console.ReadLine();
            odp = SprawdzOdpowiedz(odp);
            Console.WriteLine("Wybrano opcję nr: {0}", odp);
            if (odp == "4")
            {
                ZakonczProgram();
            };
            return odp;
        }
        static void Main(string[] args)
        {
            Console.Title = "AGD PROJECT   |   PAWEŁ SIEMIGINOWSKI (s101450)";

            Telewizor telewizor1 = new Telewizor();
            Czajnik czajnik1 = new Czajnik();
            Piekarnik piekarnik1 = new Piekarnik();

            void PokazMenuTV() {
                Console.Clear();
                Console.WriteLine("Wybrano opcję 'telewizor'.");
                bool a = true;
                while (a == true)
                {
                    Console.WriteLine(@"1. Wyświetl telewizor.
2. Pokaż obecny stan urządzenia.
3. Naciśnij przycisk TURN ON/OFF na pilocie.
4. Naciśnij przycisk MUTE na pilocie.
5. Przełącz na konkretny kanał.
6. Wróć do menu głównego."); // PODMENU
                    string wybor = Console.ReadLine();
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
                            telewizor1.Pokaz();
                            Console.ReadLine();
                            break;
                        case "2":
                            Console.Clear();
                            telewizor1.PokazStan();
                            Console.ReadLine();
                            break;
                        case "3":
                            Console.Clear();
                            telewizor1.WcisnijWlacznik();
                            Console.ReadLine();
                            break;
                        case "4":
                            Console.Clear();
                            telewizor1.WcisnijPrzyciskMute();
                            Console.ReadLine();
                            break;
                        case "5":
                            Console.Clear();
                            if(telewizor1.czyWlaczony == false)
                            {
                                Console.WriteLine("Telewizor jest obecnie wyłączony.");
                                Console.ReadLine();
                                break;
                            }
                            Console.WriteLine("Wpisz nr kanału.");
                            int temporary = Convert.ToInt32(Console.ReadLine());
                            while (temporary <= 0)
                            {
                                temporary = Convert.ToInt32(Console.ReadLine());
                            }
                            telewizor1.WybierzKanal(temporary);
                            Console.ReadLine();
                            break;
                        case "6":
                            a = false;
                            Console.WriteLine("Trwa powrót do menu głównego...");
                            Thread.Sleep(1500);
                            break;
                    }
                    Console.Clear();
                };
            }
            void PokazMenuCzajnik() {
                Console.Clear();
                Console.WriteLine("Wybrano opcję 'czajnik'.");
                bool a = true;
                while (a == true)
                {
                    Console.WriteLine(@"1. Wyświetl czajnik.
2. Pokaż obecny stan urządzenia.
3. Dolej wody.
4. Podłącz urządzenie.
5. Odłącz urządzenie.
6. Połóż czajnik na podstawkę.
7. Ściągnij czajnik z podstawki.
8. Zalej kubek wodą.
9. Wróć do menu głównego."); // PODMENU
                    string wybor = Console.ReadLine();
                    while (wybor != "1" && wybor != "2" && wybor != "3" && wybor != "4" && wybor != "5" && wybor != "6" && wybor != "7" && wybor != "8" && wybor != "9")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Błędny przycisk. Dozwolone od '1' do '9'.");
                        Thread.Sleep(1000);
                        Console.ResetColor();
                        wybor = Console.ReadLine();
                    };
                    switch (wybor)
                    {
                        case "1":
                            Console.Clear();
                            czajnik1.Pokaz();
                            Console.ReadLine();
                            break;
                        case "2":
                            Console.Clear();
                            czajnik1.PokazStan();
                            Console.ReadLine();
                            break;
                        case "3":
                            Console.Clear();
                            Console.WriteLine("Ile wody chcesz dolać? (w mililitrach)");
                            int temporary = Convert.ToInt32(Console.ReadLine());
                            while (temporary <= 0)
                            {
                                temporary = Convert.ToInt32(Console.ReadLine());
                            }
                            czajnik1.DolejWody(temporary);
                            Console.ReadLine();
                            break;
                        case "4":
                            Console.Clear();
                            czajnik1.Podlacz();
                            Console.ReadLine();
                            break;
                        case "5":
                            Console.Clear();
                            czajnik1.Odlacz();
                            Console.ReadLine();
                            break;
                        case "6":
                            Console.Clear();
                            czajnik1.PolozNaPodstawke();
                            Console.ReadLine();
                            break;
                        case "7":
                            Console.Clear();
                            czajnik1.SciagnijZPodstawki();
                            Console.ReadLine();
                            break;
                        case "8":
                            Console.Clear();
                            czajnik1.ZalejKubek();
                            Console.ReadLine();
                            break;
                        case "9":
                            a = false;
                            Console.WriteLine("Trwa powrót do menu głównego...");
                            Thread.Sleep(1500);
                            break;
                    }
                    Console.Clear();
                };
            }
            void PokazMenuPiekarnik() {
                Console.Clear();
                Console.WriteLine("Wybrano opcję 'piekarnik'.");
                bool a = true;
                while (a == true)
                {
                    Console.WriteLine(@"1. Wyświetl piekarnik.
2. Pokaż obecny stan urządzenia.
3. Włącz piekarnik.
4. Wyłącz piekarnik.
5. Ustaw pokrętło temperatury.
6. Włóż obiekt do piekarnika.
7. Wyciągnij zawartość piekarnika.
8. Wróć do menu głównego."); // PODMENU
                    string wybor = Console.ReadLine();
                    while (wybor != "1" && wybor != "2" && wybor != "3" && wybor != "4" && wybor != "5" && wybor != "6" && wybor != "7" && wybor != "8")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Błędny przycisk. Dozwolone od '1' do '8'.");
                        Thread.Sleep(1000);
                        Console.ResetColor();
                        wybor = Console.ReadLine();
                    };
                    switch (wybor)
                    {
                        case "1":
                            Console.Clear();
                            piekarnik1.Pokaz();
                            Console.ReadLine();
                            break;
                        case "2":
                            Console.Clear();
                            piekarnik1.PokazStan();
                            Console.ReadLine();
                            break;
                        case "3":
                            Console.Clear();
                            piekarnik1.Wlacz();
                            Console.ReadLine();
                            break;
                        case "4":
                            Console.Clear();
                            piekarnik1.Wylacz();
                            Console.ReadLine();
                            break;
                        case "5":
                            Console.Clear();
                            Console.WriteLine("Jaką temperaturę chcesz ustawić? (w stopniach Celsjusza - od 0 do 270)");
                            int temporary = Convert.ToInt32(Console.ReadLine());
                            while (temporary <= 0 || temporary > 270)
                            {
                                temporary = Convert.ToInt32(Console.ReadLine());
                            }
                            piekarnik1.UstawTempPiecz(temporary);
                            Console.ReadLine();
                            break;
                        case "6":
                            Console.Clear();
                            Console.WriteLine("Co chcesz umieścić w piekarniku?");
                            string obiekt1 = Console.ReadLine();
                            piekarnik1.Wloz(obiekt1);
                            Console.ReadLine();
                            break;
                        case "7":
                            Console.Clear();
                            piekarnik1.Wyjmij();
                            Console.ReadLine();
                            break;
                        case "8":
                            a = false;
                            Console.WriteLine("Trwa powrót do menu głównego...");
                            Thread.Sleep(1500);
                            break;
                    }
                    Console.Clear();
                };
            }

            Przywitaj();

            while (true)
            {
                PokazMenuPoczat();
                string odp = WybierzMenuPoczat();
                Thread.Sleep(1000);
                if (odp == "1")
                {
                    PokazMenuTV();
                }
                else if (odp == "2")
                {
                    PokazMenuCzajnik();
                }
                else if (odp == "3")
                {
                    PokazMenuPiekarnik();
                };
            };

            Thread.Sleep(3000);
            Console.WriteLine("\n\nKoniec");
            Console.ReadLine();
        }
    }
}
