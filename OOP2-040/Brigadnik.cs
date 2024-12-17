using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_040
{
    internal class Brigadnik : Zamestnanec
    {
     

        public int Odpracovano { get; set; }
        public int HodinovaMzda { get; set; }

        public Brigadnik(string jmeno, string prijmeni) : base(jmeno, prijmeni)
        {

        }


        public override int Mzda()
        {
            return Odpracovano * HodinovaMzda;
        }
    }
}
