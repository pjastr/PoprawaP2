using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2
{
    class Zawodnik:IOlimpiada
    {
        private int czas;

        public int Miejsce(string p1)
        {
            return Math.Max(p1.Length,1);
        }

        public bool Medal()
        {
            if (czas % 2 != 0) return true;
            return false;
        }

        public void UstawCzas(int czas)
        {
            this.czas = czas;
        }
    }
}
