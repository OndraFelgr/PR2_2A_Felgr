using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dědičnost
{
    internal class SporiciUcet : Ucet
    {
        public double UrokovaMira { get; set; }
        public double Urokuj()
        {
           return Stav += Stav *= UrokovaMira / 100;
        }
    }
}
