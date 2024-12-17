using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_040
{
    internal abstract class Zamestnanec
    {
        public string Jmeno { get; private set; }
        public string Prijmeni { get; private set; }

        public Zamestnanec(string jmeno, string prijmeni)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
        }

        public abstract int Mzda();

    }
}
