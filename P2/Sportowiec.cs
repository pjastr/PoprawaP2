using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2
{
    abstract class Sportowiec:IComparable<Sportowiec>
    {
        protected string imie;
        protected char klub;

        public abstract string Zawody(int param);

        public int CompareTo(Sportowiec other)
        {
            return this.imie.CompareTo(other.imie);
        }
    }
}
