using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Zad7KZat
{
    class Samochod
    {
        public static int licznikSamochodow;
        public static int DodajAuto()
        {
            return ++licznikSamochodow;
        }
        public string Marka { get { return marka; } set { marka = value; } }
        public string Model { get { return model; } set { model = value; } }
        public int Przebieg { get { return przebieg; } set { przebieg = value; } }
        private string marka;
        private string model;
        private string kolor;
        private int iloscPaliwa;
        private int paliwoKanister;
        private int przebieg;
        private int iloscKol;
        private double cisnienieOpon;
        public static int operator +(Samochod a, int b) {
            return a.iloscKol =  a.iloscKol + b;
        }
        public static string operator <(Samochod a, Samochod b)
        {
            if (a.iloscKol < b.iloscKol)
            {
                return "Pierwszy pojazd ma mniejszą ilość kół od drugiego.";
            } else
            {
                return "Pierwszy pojazd nie ma mniejszej ilości kół od drugiego.";
            }
        }
        public static string operator >(Samochod a, Samochod b)
        {
            if (a.iloscKol > b.iloscKol)
            {
                return "Pierwszy pojazd ma większą ilość kół od drugiego.";
            }
            else
            {
                return "Pierwszy pojazd nie ma większej ilości kół od drugiego.";
            }
        }

        public Samochod()
        {
            marka = "N/A";
            model = "N/A";
            kolor = "N/A";
            iloscPaliwa = 0;
            paliwoKanister = 20;
            przebieg = 0;
            iloscKol = 4;
        }
        public Samochod(string marka, string model, string kolor, int przebieg, int iloscPaliwa, double cisnienieOpon)
        {
            this.marka = marka;
            this.model = model;
            this.kolor = kolor;
            this.przebieg = przebieg;
            this.iloscPaliwa = iloscPaliwa;
            this.cisnienieOpon = cisnienieOpon;
            paliwoKanister = 20;
            iloscKol = 4;
            Samochod.DodajAuto();
        }

        public void PokazMenu()
        {
            Console.Clear();
            string wybor;
            do
            {
                Console.WriteLine("Menu SAMOCHÓD:");
                Console.WriteLine(@"1. Dokonaj przeglądu samochodu.
2. Przelakieruj.
3. Dolej zawartość kanistra do zbiornika paliwa.
4. Wymień kanister na pełny.
5. Ciśnienie opon (+0,1 bara).
6. Ciśnienie opon (-0,1 bara).
7. Wyjedź w nieznaną trasę.
8. Opuść menu."); // PODMENU
                wybor = Console.ReadLine();
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
                        PokazStan();
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Na jaki kolor chcesz przelakierować samochód?");
                        string kolor = Console.ReadLine();
                        Przelakieruj(kolor);
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.Clear();
                        DolejKanister(ref paliwoKanister);
                        Console.ReadLine();
                        break;
                    case "4":
                        Console.Clear();
                        WymienKanister();
                        Console.ReadLine();
                        break;
                    case "5":
                        Console.Clear();
                        DopompujKola(out cisnienieOpon);
                        break;
                    case "6":
                        Console.Clear();
                        WypompujKola(out cisnienieOpon);
                        break;
                    case "7":
                        Console.Clear();
                        WyjedzWTrase();
                        Console.ReadLine();
                        break;
                    case "8":
                        Console.Clear();
                        Console.WriteLine("Trwa powrót do menu głównego...");
                        Thread.Sleep(1500);
                        break;
                }
                Console.Clear();
            } while (wybor != "8");
        }
        private void PokazStan()
        {
            if (iloscPaliwa < 0)
            {
                iloscPaliwa = 0;
            }
            Console.WriteLine("Marka: {0}.", marka);
            Console.WriteLine("Model: {0}.", model);
            Console.WriteLine("Kolor: {0}.", kolor);
            Console.WriteLine("Przebieg: {0}km.", przebieg);
            Console.WriteLine("Ilość paliwa: {0}/60l.", iloscPaliwa);
            Console.WriteLine("Ciśnienie w oponach: {0}bar.", cisnienieOpon);
            Console.WriteLine("Ilość kół: {0}.", iloscKol);
            Console.WriteLine("Ilość paliwa w kanistrze w bagażniku: {0}l.", paliwoKanister);
        }
        private void Przelakieruj(string kolor)
        {
            this.kolor = kolor;
            Console.Write("Trwa lakierowanie");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".\n");
            Thread.Sleep(1000);
            Console.WriteLine("Lakierowanie zakończone.");
        }
        private void WymienKanister()
        {
            Console.WriteLine("Oddałeś stary kanister obsłudze stacji. Zabrałeś ze sobą nowy, 20-litrowy kanister.");
            paliwoKanister = 20;
        }

        private void DolejKanister(ref int paliwo)
        {
            iloscPaliwa = iloscPaliwa + paliwo;
            if (iloscPaliwa > 60)
            {
                Console.WriteLine("Rozlałeś benzynę! Bak wydaje się być pełny.");
                iloscPaliwa = 60;
            }
            else
            {
                if (paliwoKanister == 20)
                {
                    Console.WriteLine("Dolałeś 20l benzyny.");
                }
                else
                {
                    Console.WriteLine("Kanister jest pusty.");
                }
            }
            paliwo = 0;
        }
        private void DopompujKola(out double cisnienie)
        {
            cisnienie = this.cisnienieOpon;
            cisnienie += 0.1;
            if (cisnienie > 4)
            {
                cisnienie = 4;
            }
        }
        private void WypompujKola(out double cisnienieOpon)
        {
            cisnienieOpon = this.cisnienieOpon;
            cisnienieOpon -= 0.1;
            if (cisnienieOpon < 0)
            {
                cisnienieOpon = 0;
            }
        }
        private void WyjedzWTrase()
        {
            if (iloscPaliwa < 45)
            {
                Console.WriteLine("W trasę z tak małą ilością paliwa? Lepiej zatankuj przed wyjazdem.");
            }
            else
            {
                Random rnd = new Random();
                int iloscKilometrow = rnd.Next(100, 500);
                przebieg += iloscKilometrow;
                Console.WriteLine("Przejechałeś {0}km.", iloscKilometrow);
                int wypalonePaliwo = iloscKilometrow / 7;
                if (wypalonePaliwo <= iloscPaliwa)
                {
                    Console.WriteLine("Wypaliłeś {0}l paliwa.", wypalonePaliwo);
                }
                else
                {
                    Console.WriteLine("Wypaliłeś całe paliwo.");
                }
                iloscPaliwa -= wypalonePaliwo;
                if (iloscPaliwa <= 0)
                {
                    Console.WriteLine("Lepiej dotankuj samochód. Bak jest pusty.");
                }
                else
                {
                    Console.WriteLine("W baku pozostało {0}l benzyny.", iloscPaliwa);
                }
            }
        }
    }
}
