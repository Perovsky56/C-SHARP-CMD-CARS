using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Zad6KZat
{
    class Program
    {
        static void Przywitaj()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine
(@" +------------------------------------------+
 |  Projekt zadania nr 6 - PROGRAMOWANIE I  |
 |                                          |
 |             Sprzęt (pokoje)              |
 |                                          |
 |   Autor: Paweł Siemiginowski, s101450    |
 +------------------------------------------+" + "\n");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
        }
        static void Main(string[] args)
        {
            Przywitaj();
            Kuchnia kuchnia1 = new Kuchnia();
            kuchnia1.PokazMenu();
            Console.WriteLine("Trwa opuszczanie programu...");
            Thread.Sleep(2000);
        }
    }
}
