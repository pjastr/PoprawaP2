using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2
{
    class Zawody
    {
        private int iloscZawodnikow;

        private Zawody(int ilosc)
        {
            this.iloscZawodnikow = ilosc;
        }

        public static Zawody Utworz(int ilosc)
        {
            return new Zawody(ilosc);
        }
    }
}
