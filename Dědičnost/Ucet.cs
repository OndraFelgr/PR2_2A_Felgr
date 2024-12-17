using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dědičnost
{
    internal class Ucet
    {
        public double Stav { get; set; }

        public Ucet(double pocatecniStav = 0)
        {
            if (pocatecniStav < 0)
            {
                throw new ArgumentException("Počáteční stav nemůže být záporný.");
            }
            Stav = pocatecniStav;
        }

        public double  Uloz(double castka)
        {
            if(castka <= 0)
            {
                throw new ArgumentException("Počáteční stav nemůže být záporný.");
            }
            return Stav += castka;
        }

        public double Vyber(double castka)
        {
            if (castka <= 0 || castka > Stav)
            {
                throw new ArgumentException("Počáteční stav nemůže být záporný.");
            }
            return Stav -= castka;
        }

        public override string ToString()
        {
            return $"Tvůj stav účtu je {Stav}";
        }
    }
}
