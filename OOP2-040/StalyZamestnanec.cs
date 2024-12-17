using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_040
{
    internal class StalyZamestnanec : Zamestnanec
    {
        private int _mzda;

        public StalyZamestnanec(string jmeno, string prijmeni, int mzda) : base(jmeno, prijmeni)
        {
            _mzda = mzda;
        }


        public override int Mzda()
        {
            return _mzda;
        }
    }
}
