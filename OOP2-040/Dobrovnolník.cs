using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_040
{
    internal class Dobrovnolnik : Zamestnanec
    {
        public Dobrovnolnik(string jmeno, string prijmeni) : base(jmeno, prijmeni)
        {
        }

        public override int Mzda()
        {
            return 0;
        }
    }
}
