using System.IO;

namespace Test_DedicnostInterface
{

   enum Pohlavi { Muz, Zena }

    class Clovek
    {
        public string Jmeno { get;private init; }
        public Pohlavi Pohlavii { get; private init; }

        public Clovek(string jmeno, Pohlavi pohlavii)
        {
            Jmeno = jmeno;
            Pohlavii = pohlavii;
        }

        public override string ToString()
        {
            return $"Jmenuji se {Jmeno} a jsem {Pohlavii}";
        }
    }

    abstract class Zamestnanec : Clovek
    {
        public Zamestnanec(string jmeno, Pohlavi pohlavii, int mzda) : base(jmeno, pohlavii)
        {
        }
            
        protected Zamestnanec(string jmeno, Pohlavi pohlavii,int mzda, string povolani) : base(jmeno, pohlavii)
        {
            Povolani = povolani;
            Mzda = mzda;
        }

        public int Mzda { get; set; }
        public string Povolani { get; private init; }

        public abstract string Pracuj();


    }

     class Ucetni : Zamestnanec
    {
        public Ucetni(string jmeno, Pohlavi pohlavii, int mzda) : base("účetní", pohlavii, mzda)
        {
        }

        public override string Pracuj()
        {
            return "Kontroluji faktury";
        }
    }

     class Kuchar : Zamestnanec
    {
        public Kuchar(string jmeno, Pohlavi pohlavii, int mzda, string povolani) : base(jmeno, pohlavii, mzda, povolani)
        {
        }

        public Kuchar(string jmeno, Pohlavi pohlavii, int mzda, string povolani, string hotel) : base(jmeno, pohlavii, mzda, "kuchař")
        {
        }


        public override string Pracuj()
        {
            return "Klepu řízky v hotelu …";
        }
    }

    class Skupina
    {

        List<Zamestnanec>_zamestnanci = new List<Zamestnanec>();

        public Skupina(List<Zamestnanec> zamestnanci)
        {
            _zamestnanci = zamestnanci;
        }

        public Skupina(Zamestnanec[] lide)
        {
            Lide = lide;
        }

        public string DoPrace()
        {
            int pocet = 0;
            foreach(var zamestnanec in _zamestnanci)
            {
                pocet++;
            }

           foreach (var zamestnanec in _zamestnanci)
            {
                Console.WriteLine(zamestnanec);
            }
            return $"Pracuje {pocet} zaměstanců";       
        }

        public string Popis { get { return "Skupina 3 mužů a 5 žen"; } }
        

        public double PrumernaMzda { 
            get
            {
                int celkove = 0;
                int pocet = 0;
                foreach (var zamestnanec in _zamestnanci)
                {
                    pocet++;
                    zamestnanec.Mzda += celkove;
                }
                return celkove / pocet;
            }
           
        }

        public Zamestnanec[] Lide { get; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Test();
        }

        public static void Test()
        {
            Ucetni franta = new Ucetni("František", Pohlavi.Muz, 31000);
            Ucetni alena = new Ucetni("Alena", Pohlavi.Zena, 33000);

            Kuchar martin = new Kuchar("Martin", Pohlavi.Muz, 25000, "Modrá hvězda");
            Kuchar jirina = new Kuchar("Jiřina", Pohlavi.Zena, 27000, "Barrique");
            Kuchar tomas = new Kuchar("Tomáš", Pohlavi.Muz, 29000, "Sommelier");
            Console.WriteLine(tomas); //vypíše něco jako "Jmenuji se Tomáš a jsem muž"

            Zamestnanec[] lide = { franta, alena, martin, jirina, tomas };

            Skupina parta = new Skupina(lide);

            Console.WriteLine(parta.Popis); //vypíše "Skupina 3 mužů a 2 žen"
           

            Console.WriteLine();
            parta.DoPrace();
            // Poslední příkaz vypíše      
            // Pracuje 5 zaměstanců
            // František: Kontroluji faktury
            // Alena: Kontroluji faktury
            // Martin: Klepu řízky v hotelu Modrá hvězda
            // Jiřina: Klepu řízky v hotelu Barrique
            // Tomáš: Klepu řízky v hotelu Sommelier

        }
    }
}
