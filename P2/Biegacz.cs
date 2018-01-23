using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2
{
    class Biegacz:Sportowiec, IComparable<Biegacz>
    {
        private int rekord;

        public Biegacz(string p1, char p2, int p3)
        {
            this.imie = p1;
            this.klub = p2;
            this.rekord = p3;
        }

        public override string Zawody(int param)
        {
            string opis = "";
            for (int i = 0; i < param;i++)
            {
                opis += "a";
            }
            return opis;
        }

        public override string ToString()
        {
            return String.Format("Biegacz, imie: {0}, klub: {1}, rekord: {2}",imie,klub,rekord);
        }

        public int CompareTo(Biegacz other)
        {
            return other.rekord.CompareTo(this.rekord);
        }
    }
}
