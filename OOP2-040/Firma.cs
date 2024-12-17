using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_040
{
    internal class Firma
    {
        private List<Zamestnanec> _lidi = new List<Zamestnanec>();
        public void Zamestnej(Zamestnanec z)
        {
            if (!_lidi.Contains(z))
                _lidi.Add(z);
        }

        public void Propust(Zamestnanec z)
        {
            _lidi.Remove(z);
        }

        public void Vyplata()
        {
            int total = 0;
            int mzda;
            foreach(Zamestnanec z in _lidi)
            {
                mzda = z.Mzda();
                total += mzda;
                Console.WriteLine($"{z.Jmeno} {z.Prijmeni} {mzda}");
            }
            Console.WriteLine(new string('_' ,20));
            Console.WriteLine(total);


        }
    }
}
