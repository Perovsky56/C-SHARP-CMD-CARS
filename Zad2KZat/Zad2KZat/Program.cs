using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zad2KZat
{
    class Program
    {
        static void Przywitaj()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine
(@" +------------------------------------------+
 |  Projekt zadania nr 2 - PROGRAMOWANIE I  |
 |                                          |
 |  Propozycja utworu rockowego/metalowego  |
 |           na podstawie wyborów           |
 |                                          |
 |   Autor: Paweł Siemiginowski, s101450    |
 +------------------------------------------+" + "\n");
            Console.ResetColor();
            Thread.Sleep(1000);
        }

        static void Pozegnaj()
        {
            Console.WriteLine("\n\nKliknij 'enter', aby zakończyć działanie programu...");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.ReadLine(); //end
            Console.ResetColor();
            Console.WriteLine("Trwa wyłączanie programu...");
            Thread.Sleep(2000);
        }

        static void PokazWyborPoczatek()
        {
            string przyciskPrzejscie = "t";
            do
            {
                Console.WriteLine("\nCzy chcesz rozpocząć wypełnianie ankiety? (t/n)");
                przyciskPrzejscie = Console.ReadLine();
                if (przyciskPrzejscie == "n")
                {
                    Console.WriteLine("Trwa zamykanie programu...");
                    Thread.Sleep(3000);
                    System.Environment.Exit(1);
                }
                if (przyciskPrzejscie != "t")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Użyto błędny znak...");
                    Thread.Sleep(1000);
                    Console.ResetColor();
                }
            } while (przyciskPrzejscie != "t");
        }

        static string SprawdzOdpowiedz(string odp)
        {
           while (odp != "a" && odp != "b" && odp != "c" && odp != "d"){
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Błędny przycisk. Dozwolone: 'a', 'b', 'c' lub 'd'.");
                Thread.Sleep(1000);
                Console.ResetColor();
                odp = Console.ReadLine();
            };
           return odp;
        }

        static void Main(string[] args)
        {
            Console.Title = "Propozycja utworu rockowego/metalowego na podstawie wyborów.   |   Paweł Siemiginowski (s101450)";
            Przywitaj();
            PokazWyborPoczatek();

            int wagaUtworu = 0;
            int gatunek = 0;

            void DodajPunkty(string odp)
            {
                switch (odp)
                {
                    case "a":
                        wagaUtworu += 2;
                        break;

                    case "b":
                        wagaUtworu++;
                        break;

                    case "c":
                        wagaUtworu--;
                        break;

                    case "d":
                        wagaUtworu -= 2;
                        break;
                };
            }

            void WyswietlPytanie(int nrPyt, string pytanie, string odpA, string odpB, string odpC, string odpD)
            {
                Console.WriteLine("\n=====================================");
                Console.WriteLine("Pytanie nr {0}. {1}", nrPyt, pytanie);
                Console.WriteLine("a) {0}", odpA);
                Console.WriteLine("b) {0}", odpB);
                Console.WriteLine("c) {0}", odpC);
                Console.WriteLine("d) {0}", odpD);
                Console.Write("Odp.: ");
                string [] odp = new string[10];
                odp[nrPyt - 1] = Console.ReadLine();
                odp[nrPyt - 1] = SprawdzOdpowiedz(odp[nrPyt - 1]);
                if (nrPyt == 1)
                {
                    switch (odp[0])
                    {
                        case "a":
                            gatunek = 1;
                            break;
                        case "b":
                            gatunek = 2;
                            break;
                        case "c":
                            gatunek = 3;
                            break;
                        case "d":
                            gatunek = 4;
                            break;
                    }
                } else
                {
                    DodajPunkty(odp[nrPyt - 1]);
                }
            };

            string WysUtwor()
            {
                if (gatunek == 1)
                {
                    if (wagaUtworu > 9)
                    {
                        return "Death - 'Lack of Comprehension'";
                    }
                    else if (wagaUtworu > 0 && wagaUtworu <= 9)
                    {
                        return "Motörhead - 'Ace of Spades'";
                    }
                    else if (wagaUtworu < 0 && wagaUtworu >= -9)
                    {
                        return "Slipknot - 'Psychosocial'";
                    }
                    else
                    {
                        return "Disturbed - 'Down With The Sickness'";
                    }
                }
                else if (gatunek == 2)
                {
                    if (wagaUtworu > 9)
                    {
                        return "Megadeth - 'Symphony of Destruction'";
                    }
                    else if (wagaUtworu > 0 && wagaUtworu <= 9)
                    {
                        return "Metallica - 'Fade to Black'";
                    }
                    else if (wagaUtworu < 0 && wagaUtworu >= -9)
                    {
                        return "Sabaton - '40:1'";
                    }
                    else
                    {
                        return "Rammstein - 'Deutschland'";
                    }
                }
                else if (gatunek == 3)
                {
                    if (wagaUtworu > 9)
                    {
                        return "AC/DC - 'Hells Bells'";
                    }
                    else if (wagaUtworu > 0 && wagaUtworu <= 9)
                    {
                        return "Guns N' Roses - 'November Rain'";
                    }
                    else if (wagaUtworu < 0 && wagaUtworu >= -9)
                    {
                        return "Bon Jovi - 'Livin' On a Prayer'";
                    }
                    else
                    {
                        return "Led Zeppelin - 'Stairway to Heaven'";
                    }
                }
                else if (gatunek == 4)
                {
                    if (wagaUtworu > 9)
                    {
                        return "Queen - 'Bohemian Rhapsody'";
                    }
                    else if (wagaUtworu > 0 && wagaUtworu <= 9)
                    {
                        return "Audioslave - 'Like a Stone'";
                    }
                    else if (wagaUtworu < 0 && wagaUtworu >= -9)
                    {
                        return "Seether - 'Broken'";
                    }
                    else
                    {
                        return "Michael Jackson - 'Beat It'";
                    }
                } else
                {
                    return "błąd";
                }
            }

            WyswietlPytanie(1, "Wybierz swój ulubiony gatunek muzycznych z podanych:", "Heavy Metal", "Thrash Metal", "Heavy Rock", "Soft Rock");
            WyswietlPytanie(2, "Który instrument Twoim zdaniem ma największe znaczenie w zespole muzycznym?", "Gitara elektryczna", "Perkusja", "Gitara basowa", "Keyboard");
            WyswietlPytanie(3, "Wybierz najlepszego wokalistę rockowego/metalowego z podanych:", "Corey Taylor (Slipknot)", "James Hetfield (Metallica)", "Axl Rose (Guns N' Roses)", "David Gilmour (Pink Floyd)");
            WyswietlPytanie(4, "Wybierz najlepszego gitarzystę z podanych:", "Kirk Hammett (Metallica)", "Slash (Guns N' Roses)", "Mark Knopfler (Dire Straits)", "Jimi Hendrix");
            WyswietlPytanie(5, "Który utwór z podanych jest wg. Ciebie najlepszy?", "'Symphony of Destruction' zespołu Megadeth", "'Iron Man' zespołu Black Sabbath", "'Comfortably Numb' zespołu Pink Floyd", "'Purple Haze' autorstwa Jimi'ego Hendrix'a");
            WyswietlPytanie(6, "Który zespół z podanych jest wg. Ciebie najlepszy?", "Disturbed", "Five Finger Death Punch", "Shinedown", "Seether");
            WyswietlPytanie(7, "Wybierz najlepszego perkusistę z podanych:", "Lars Ulrich (Metallica)", "Dave Grohl (Nirvana, Foo Fighters)", "Steward Copeland (The Police)", "Phil Collins");
            WyswietlPytanie(8, "Który zespół pojawiłby się na twoim wymarzonym koncercie?", "Motörhead", "Slayer", "Led Zeppelin", "Dire Straits");
            WyswietlPytanie(9, "Najlepsza gitarowa 'solówka' pochodzi z utworu?", "'Eruption' - Van Halen", "'Crazy Train' - Randy Rhoads (Ozzy Osbourne)", "'Stairway to Heaven' - Led Zeppelin", "'All Along the Watchtower' - Jimi Hendrix");
            WyswietlPytanie(10, "Ulubiony basista rockowy/metalowy?", "Steve Harris - Iron Maiden", "Cliff Burton - Metallica", "Cliff Williams - AC/DC", "John Paul Jones - Led Zeppelin");

            Console.WriteLine();
            Console.WriteLine();
            //Console.WriteLine("Waga kawałka: " + wagaUtworu);
            //Console.WriteLine("Gatunek: " + gatunek);
            //Console.WriteLine();
            //Console.WriteLine();

            string wynikKoncowy = WysUtwor();
            Thread.Sleep(1500);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Polecany utwór: " + wynikKoncowy);
            Console.ResetColor();
            Thread.Sleep(1500);
            Pozegnaj();
        }
    }
}