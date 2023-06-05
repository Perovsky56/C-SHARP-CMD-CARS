using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad5KZat
{
    class Rybka
    {
        private int czystoscWody;
        private int iloscJedzenia;
        private int poziomMilosci;
        public Rybka()
        {
            czystoscWody = 10;
            iloscJedzenia = 0;
            poziomMilosci = 0;
        }
        public Rybka(int czystoscWody, int iloscJedzenia, int poziomMilosci)
        {
            this.czystoscWody = czystoscWody;
            this.iloscJedzenia = iloscJedzenia;
            this.poziomMilosci = poziomMilosci;
        }
        public Rybka(Rybka rybeczka)
        {
            czystoscWody = rybeczka.czystoscWody;
            iloscJedzenia = rybeczka.iloscJedzenia;
            poziomMilosci = rybeczka.poziomMilosci;
        }

        public void SprawdzStanRybki()
        {
            Console.WriteLine("Czystość wody: {0}/10.", czystoscWody);
            Console.WriteLine("Ilość jedzenia w akwarium: {0}g.", iloscJedzenia);
            Console.WriteLine("Poziom przywiązania rybki do właściciela: {0}/10.", poziomMilosci);
        }

        public void WyczyscAkwarium()
        {
            if (czystoscWody < 10)
            {
                Console.WriteLine("Wyczyszczono akwarium.");
                czystoscWody = 10;
                iloscJedzenia = 0;
            } else
            {
                iloscJedzenia = 0;
                Console.WriteLine("Akwarium jest czyste.");
            }
        }
        public void NasypJedzenia(int iloscJedz)
        {
            czystoscWody -= 2;
            if (czystoscWody < 0)
            {
                czystoscWody = 0;
                Console.WriteLine("Woda jest brudna.");
                poziomMilosci = 0;
            }
            Console.WriteLine("Dosypano {0}g jedzenia.", iloscJedz);
            iloscJedzenia += iloscJedz;
            if (iloscJedzenia > 10)
            {
                iloscJedzenia = 10;
                czystoscWody = 0;
                Console.WriteLine("Jedzenie się wysypało. Akwarium jest pełne.");
            }
        }
        public void PobawSie()
        {
            poziomMilosci += 2;
            Console.WriteLine("Zwróciłeś uwagę rybki poprzez stukanie w akwarium.");
            if(poziomMilosci > 10)
            {
                poziomMilosci = 10;
                Console.WriteLine("Rybka kocha Cię!");
            }
        }
    }
}
