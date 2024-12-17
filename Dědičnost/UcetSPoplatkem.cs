using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dědičnost
{
    internal class UcetSPoplatkem : Ucet
    {
        public double PoplatekZaVyber { get; set; }
        public double PoplatekZaVklad { get; set; }

       
        public double VyberSPoplatkem(double castka)
        {
            if (castka <= 0)
            {
                throw new ArgumentException("Částka pro výběr musí být kladná.");
            }

            if (castka + PoplatekZaVyber > Stav)
            {
                throw new InvalidOperationException("Nedostatečné prostředky na pokrytí částky a poplatku za výběr.");
            }

            Stav -= PoplatekZaVyber; 
            return base.Vyber(castka);
        }

        public new string ToString()
        {
            return base.ToString() + $", Poplatek za výběr: {PoplatekZaVyber}, Poplatek za vklad: {PoplatekZaVklad}";
        }
    }
}
