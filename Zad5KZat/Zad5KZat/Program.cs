using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Zad5KZat
{
    class Program
    {
        static void Przywitaj()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine
(@" +------------------------------------------+
 |  Projekt zadania nr 5 - PROGRAMOWANIE I  |
 |                                          |
 |                ZWIERZĘTA                 |
 |                                          |
 |   Autor: Paweł Siemiginowski, s101450    |
 +------------------------------------------+" + "\n");
            Console.ResetColor();
            Thread.Sleep(2000);
            Console.Clear();
        }       
        static void Main(string[] args)
        {
            Console.Title = "Zwierzęta   |   Paweł Siemiginowski (s101450)";
            Pies pies1 = new Pies();
            Rybka rybka1 = new Rybka();
            void PokazMenuGl()
            {
                string wyborGl;
                while (true)
                {
                    Console.WriteLine("Wybierz zwierzaka.");
                    Console.WriteLine("1. Pies.");
                    Console.WriteLine("2. Rybka.");
                    Console.WriteLine("3. Wyjdź z programu.");
                    wyborGl = Console.ReadLine();
                    if (wyborGl != "1" && wyborGl != "2" && wyborGl != "3")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Zły przycisk. Dozwolone '1', '2' lub '3'.\n");
                        Console.ResetColor();
                    }
                    if (wyborGl == "1")
                    {
                        Console.Clear();
                        PokazMenuPies();
                    }
                    else if (wyborGl == "2")
                    {
                        Console.Clear();
                        PokazMenuRybka();
                    }
                    else if (wyborGl == "3")
                    {
                        Console.Write("\nTrwa opuszczanie programu");
                        Thread.Sleep(750);
                        Console.Write(".");
                        Thread.Sleep(750);
                        Console.Write(".");
                        Thread.Sleep(750);
                        Console.Write(".");
                        Thread.Sleep(750);
                        Environment.Exit(1);
                    }
                }
            }
            void PokazMenuPies()
            {
                string wyborPies;
                bool wyjscieMenuPies = true;
                while (wyjscieMenuPies == true)
                {
                    Console.Clear();
                    Console.WriteLine(@"1. Sprawdź stan swojego psa.
2. Zmień kolor obroży.
3. Nakarm psa.
4. Pogłaskaj psa.
5. Wyjdź.");
                    wyborPies = Console.ReadLine();
                    if (wyborPies != "1" && wyborPies != "2" && wyborPies != "3" && wyborPies != "4" && wyborPies != "5")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nZły przycisk. Dozwolone '1', '2', '3', '4' lub '5'.\n");
                        Console.ResetColor();
                        Thread.Sleep(1500);
                    }
                    if (wyborPies == "1")
                    {
                        Console.Clear();
                        pies1.SprawdzStanPsa();
                        Console.ReadLine();
                    }
                    else if (wyborPies == "2")
                    {
                        Console.Clear();
                        Console.WriteLine("Podaj kolor obroży, jaką chcesz założyć.");
                        string kolorObrozy = Console.ReadLine();
                        pies1.ZalozObroze(kolorObrozy);
                        Console.ReadLine();
                    }
                    else if (wyborPies == "3")
                    {
                        Console.Clear();
                        Console.WriteLine("Podaj jaką sytość posiada jedzenie.");
                        string stringSytosc = Console.ReadLine();
                        int sytosc = Int32.Parse(stringSytosc);
                        pies1.Nakarm(sytosc);
                        Console.ReadLine();
                    }
                    else if (wyborPies == "4")
                    {
                        Console.Clear();
                        pies1.Poglaskaj();
                        Console.ReadLine();
                    }
                    else if (wyborPies == "5")
                    {
                        Console.WriteLine("Opuszczasz menu 'pies'.");
                        Thread.Sleep(2000);
                        Console.Clear();
                        wyjscieMenuPies = false;
                    }
                }
            }
            void PokazMenuRybka()
            {
                string wyborRybka;
                bool wyjscieMenuRybka = true;
                while (wyjscieMenuRybka == true)
                {
                    Console.Clear();
                    Console.WriteLine(@"1. Sprawdź stan swojej rybki.
2. Wyczyść akwarium.
3. Dosyp jedzenia do akwarium.
4. Zwróć uwagę rybki.
5. Wyjdź.");
                    wyborRybka = Console.ReadLine();
                    if (wyborRybka != "1" && wyborRybka != "2" && wyborRybka != "3" && wyborRybka != "4" && wyborRybka != "5")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nZły przycisk. Dozwolone '1', '2', '3', '4' lub '5'.\n");
                        Console.ResetColor();
                        Thread.Sleep(1500);
                    }
                    if (wyborRybka == "1")
                    {
                        Console.Clear();
                        rybka1.SprawdzStanRybki();
                        Console.ReadLine();
                    }
                    else if (wyborRybka == "2")
                    {
                        Console.Clear();
                        rybka1.WyczyscAkwarium();
                        Console.ReadLine();
                    }
                    else if (wyborRybka == "3")
                    {
                        Console.Clear();
                        Console.WriteLine("Ile gram jedzenia chcesz dosypać?");
                        string sJedzenie = Console.ReadLine();
                        int jedzenie = Int32.Parse(sJedzenie);
                        rybka1.NasypJedzenia(jedzenie);
                        Console.ReadLine();
                    }
                    else if (wyborRybka == "4")
                    {
                        Console.Clear();
                        rybka1.PobawSie();
                        Console.ReadLine();
                    }
                    else if (wyborRybka == "5")
                    {
                        Console.WriteLine("Opuszczasz menu 'rybka'.");
                        Thread.Sleep(2000);
                        Console.Clear();
                        wyjscieMenuRybka = false;
                    }
                }
            }



            Przywitaj();

            //PokazMenuGl();

            Console.WriteLine("======= PIES =======");
            Console.WriteLine("Obiekt z konstruktora domyślnego:");
            Pies pies2 = new Pies();
            pies2.SprawdzStanPsa();
            Console.WriteLine("\nObiekt z konstruktora z argumentami:");
            Pies pies3 = new Pies("czerwony", 5, 7);
            pies3.SprawdzStanPsa();
            pies3.Poglaskaj();
            pies3.SprawdzStanPsa();
            Console.WriteLine("\nObiekt z konstruktora kopiującego:");
            Pies pies4 = new Pies(pies3);
            pies4.SprawdzStanPsa();

            Console.WriteLine("\n\n======= RYBKA =======");
            Console.WriteLine("Obiekt z konstruktora domyślnego:");
            Rybka rybka2 = new Rybka();
            rybka2.SprawdzStanRybki();
            Console.WriteLine("\nObiekt z konstruktora z argumentami:");
            Rybka rybka3 = new Rybka(5, 6, 3);
            rybka3.SprawdzStanRybki();
            rybka3.PobawSie();
            rybka3.SprawdzStanRybki();
            Console.WriteLine("\nObiekt z konstruktora kopiującego:");
            Rybka rybka4 = new Rybka(rybka3);
            rybka4.SprawdzStanRybki();

            Console.ReadLine();
        }
    }
}
