using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Zad7KZat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Paweł Siemiginowski (s101450)   |   ZADANIE NR 8";
            Console.WriteLine("Liczba aut na start: {0}", Samochod.licznikSamochodow);
            Console.ReadLine();

            Samochod auto1 = new Samochod("VW", "GOLF", "Czerwony", 84750, 17, 2.0);
            Samochod auto2 = new Samochod("Audi", "A3", "Niebieski", 44750, 18, 2.3);

            string wybor;
            do
            {
                var opisAuto1 = new Samochod { Marka = auto1.Marka, Model = auto1.Model, Przebieg = auto1.Przebieg };
                var opisAuto2 = new Samochod { Marka = auto2.Marka, Model = auto2.Model, Przebieg = auto2.Przebieg };
                Console.WriteLine("Samochody:");
                Console.WriteLine("1. {0} {1} ({2}km)", opisAuto1.Marka, opisAuto1.Model, opisAuto1.Przebieg);
                Console.WriteLine("2. {0} {1} ({2}km)", opisAuto2.Marka, opisAuto2.Model, opisAuto2.Przebieg);
                Console.WriteLine("3. Dodaj koło do auta pierwszego.");
                Console.WriteLine("4. Dodaj koło do auta drugiego.");
                Console.WriteLine("5. Czy pierwsze auto ma więcej kół od drugiego?");
                Console.WriteLine("6. Czy pierwsze auto ma mniej kół od drugiego?");
                Console.WriteLine("7. Wyjdź z programu.");
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
                        auto1.PokazMenu();
                        break;
                    case "2":
                        Console.Clear();
                        auto2.PokazMenu();
                        break;
                    case "3":
                        Console.Write("Liczba kół w pierwszym aucie po dodaniu następnego: " + (auto1 + 1));
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "4":
                        Console.Write("Liczba kół w drugim aucie po dodaniu następnego: " + (auto2 + 1));
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "5":
                        Console.Write(auto1 < auto2);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "6":
                        Console.Write(auto1 > auto2);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "7":
                        Console.WriteLine("Trwa wychodzenie...");
                        Thread.Sleep(1500);
                        break;
                }
            } while (wybor != "7");
            Console.WriteLine("Liczba aut na koniec: {0}", Samochod.licznikSamochodow);
            Console.ReadLine();
        }
    }
}
