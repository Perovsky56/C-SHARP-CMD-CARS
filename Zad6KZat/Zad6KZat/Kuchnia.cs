using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Zad6KZat
{
    class Kuchnia
    {
        public class Czajnik {
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
        public class Piekarnik {
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
                } else
                {
                    Console.WriteLine("Piekarnik został opróżniony.");
                    pieczonyObiekt = "";
                }
                czyObiektUpieczony = false;
            }
        }
        public class Okap {
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
            private void WlaczWyciag() {
                czyWyciagWlaczony = true;
                Console.WriteLine("Okap zaczyna wyciągać powietrze z pomieszczenia...");
            }
            private void WylaczWyciag() {
                czyWyciagWlaczony = false;
                Console.WriteLine("Wyciąg powietrza przez okap został wyłączony.");
            }
            private void WlaczSwiatlo() {
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
}
