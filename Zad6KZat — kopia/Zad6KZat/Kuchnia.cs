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
        private Czajnik czajnik1 = new Czajnik();
        private Piekarnik piekarnik1 = new Piekarnik();
        private Okap okap1 = new Okap();

        public void PokazMenu()
        {
            string odp;
            do
            {
                Console.WriteLine(@"Wybierz urządzenie kuchenne, które chcesz użyć.
1. Czajnik.
2. Piekarnik.
3. Okap.
4. Wyjdź."); //MENU
                odp = Console.ReadLine();
                if (odp != "1" && odp != "2" && odp != "3" && odp != "4")
                {
                    Console.Clear();
                    Console.WriteLine("Użyto błędnego znaku. Spróbuj ponownie.");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
                switch (odp)
                {
                    case "1":
                        czajnik1.PokazMenu();
                        break;
                    case "2":
                        piekarnik1.PokazMenu();
                        break;
                    case "3":
                        okap1.PokazMenu();
                        break;
                }
                Console.Clear();
            } while (odp != "4");
        }
    }
  
}
