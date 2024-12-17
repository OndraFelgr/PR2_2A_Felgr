namespace OOP2_060
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IUtvar[] utvary = new IUtvar[4];
            utvary[0] = new Ctverec(3);
            utvary[1] = new Kruh(3);
            utvary[2] = new Trojuhelnik(3, 2, 2);

            double obvodTotal = 0;
            double obsahTotal = 0;

            foreach(IUtvar utvar in utvary)
            { 
                Console.WriteLine(utvar);
                
                obvodTotal += utvar.GetObvod();
                obsahTotal += utvar.GetObsah();
            }
            Console.WriteLine($"Celkovy obvod je {obvodTotal} a obsah je {obsahTotal}");

            Dictionary<string, int> pocty = [];
            foreach (IUtvar utvar in utvary)
            {
                if (pocty.ContainsKey(utvar.Nazev))
                    {
                    pocty[utvar.Nazev]++;
                }

                else
                {
                    pocty[utvar.Nazev] = 1;
                }

            }
            foreach(var kvp in pocty)
            {
                Console.WriteLine($"{kvp.Key} {kvp.Value}");
            }


        }
    }
    interface IUtvar
    {
        string Nazev { get;}
        double GetObvod();
        double GetObsah();
    }

    sealed class Ctverec : IUtvar
    {
        public double Strana { get; private set; }

        public string Nazev => "čtverec";
        public Ctverec(double strana )

        {
            
            Strana = strana;
        }

        public double GetObvod()
        {
           return 4 * Strana;
        }
        
        public double GetObsah()
        {
            return Strana * Strana;
        }
        public override string? ToString()
        {
            return $"Čtverec o straně {Strana} ma obvod {GetObvod} a obsah {GetObsah}";
        }
    }

    sealed class Kruh : IUtvar
    {
        public double Polomer { get; private set; }

        public string Nazev => "kruh";
        public Kruh(double strana)

        {

            Polomer = strana;
        }

        public double GetObvod()
        {
            return 2 * Math.PI * Polomer;
        }

        public double GetObsah()
        {
            return Polomer * Math.PI;
        }
        public override string? ToString()
        {
            return $"Čtverec o straně {Polomer} ma obvod {GetObvod} a obsah {GetObsah}";
        }
    }

    sealed class Trojuhelnik : IUtvar
    {
        public double Strana1 { get; init; }
        public double Strana2 { get; init; }
        public double Strana3 { get; init; }

        public string Nazev => "trojuhelnik";

        public Trojuhelnik(double strana1, double strana2, double strana3)
        {
            Strana1 = strana1;
            Strana2 = strana2;
            Strana3 = strana3;
        }

        public double GetObvod()
        {
            return Strana1 + Strana2 + Strana3;
        }

        public double GetObsah()
        {
            double s = GetObvod() / 2;
            return Math.Sqrt(s * (s - Strana1) * (s - Strana2) * (s - Strana3));
        }
        public override string? ToString()
        {
            return $"Trojuhelnik o straně {Strana1} ma obvod {GetObvod} a obsah {GetObsah}";
        }
    }

    class PlechovkaBarvy
    {
        public double Objem { get; set; }
        public double Vydatnost { get; set; }

        public PlechovkaBarvy(double objem, double vydatnost)
        {
            Objem = objem;
            Vydatnost = vydatnost;
        }

        public bool Obarvi(IUtvar z)
        {
            if()
        }
        public override string? ToString()
        {
            return $"Plechovka barvy, zbývá jí ještě na 60 cm²";
        }
    }
}
