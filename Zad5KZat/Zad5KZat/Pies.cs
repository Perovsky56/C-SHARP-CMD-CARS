using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad5KZat
{
    class Pies
    {
        private string kolorObrozy;
        private int poziomGlodu;
        private int poziomStresu;

        public Pies()
        {
            kolorObrozy = "czerwony";
            poziomGlodu = 10;
            poziomStresu = 0;
        }
        public Pies(string kolorObrozy, int poziomGlodu, int poziomStresu)
        {
            this.kolorObrozy = kolorObrozy;
            this.poziomGlodu = poziomGlodu;
            this.poziomStresu = poziomStresu;
        }
        public Pies(Pies piesek)
        {
            kolorObrozy = piesek.kolorObrozy;
            poziomGlodu = piesek.poziomGlodu;
            poziomStresu = piesek.poziomStresu;
        }

        public void SprawdzStanPsa()
        {
            Console.WriteLine("Kolor obroży: {0}.", kolorObrozy);
            Console.WriteLine("Poziom głodu: {0}/10.", poziomGlodu);
            Console.WriteLine("Poziom stresu: {0}/10.", poziomStresu);
            if (poziomStresu == 0 && poziomGlodu == 0)
            {
                Console.WriteLine("Twój pies jest najczęśliwszym zwierzakiem na ziemi.");
            }
        }
        public void ZalozObroze(string kolorObrozy)
        {
            this.kolorObrozy = kolorObrozy;
            Console.WriteLine("Założyłeś swojemu zwierzakowi obrożę w kolorze: {0}.", this.kolorObrozy);
            poziomStresu += 2;
            if (poziomStresu > 10)
            {
                poziomStresu = 10;
            }
        }

        public void Nakarm(int sytoscJedzenia)
        {
            poziomGlodu -= sytoscJedzenia;
            Console.WriteLine("Twoj pies dostał jeść.");
            if (poziomGlodu < 0)
            {
                Console.WriteLine("Twój pies się przejadł.");
                poziomGlodu = 0;
                poziomStresu += 2;
                if (poziomStresu > 10)
                {
                    poziomStresu = 10;
                    Console.WriteLine("Stres osiągnął maksymalny poziom.");
                } else {
                    Console.WriteLine("Poziom stresu wzrósł do: {0}/10", poziomStresu);
                }
            }
        }
        public void Poglaskaj()
        {
            if (poziomStresu > 0)
            {
                poziomStresu--;
            }

            if (poziomStresu < 10 && poziomStresu > 0) {
                Console.WriteLine("Twój pies cieszy się. Jego poziom stresu spada. Obecnie wynosi {0}/10.", poziomStresu);
            } else if (poziomStresu == 0)
            {
                Console.WriteLine("Twój pies jest niesamowicie spokojny.");
            }

            poziomGlodu += 2;
            if (poziomGlodu > 10)
            {
                poziomGlodu = 10;
                Console.WriteLine("Pies umiera z głodu. Nakarm go.");
            }
        }
    }
}
