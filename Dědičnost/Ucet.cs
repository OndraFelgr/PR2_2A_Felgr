using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dědičnost
{
    internal class Ucet
    {
        public double Stav { get; private set; }

        public Ucet(double pocatecniStav = 0)
        {
            if (pocatecniStav < 0)
            {
                throw new ArgumentException("Počáteční stav nemůže být záporný.");
            }
            Stav = pocatecniStav;
        }
    }
}
