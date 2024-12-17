namespace OOP2_050
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Flotila flotila = new Flotila();

            flotila.PridejVozidlo(new ElektroAuto(160, 2));
            flotila.PridejVozidlo(new DieselAuto(180, 5));


            Console.WriteLine(flotila.Kapacita);
            flotila.Natankuj();

            flotila.PridejVozidlo(new DieselAuto(130, 5));

           

        }
    }

    abstract class DopravniProstredek
    {
        public string Nazev { get; set; }
        public TypPohonu Pohon { get; set; }
        public double MaxRychlost { get; set; }
        public int PocetMist { get; set; }

        public DopravniProstredek(string nazev, TypPohonu pohon, double maxRychlost, int pocetMist)
        {
            Nazev = nazev;
            Pohon = pohon;
            MaxRychlost = maxRychlost;
            PocetMist = pocetMist;
        }

        public abstract string Natankuj();

        public override string? ToString()
        {
            return $"{Nazev} {Pohon} {MaxRychlost} {PocetMist}";
        }
    }

   sealed class Motocykl : DopravniProstredek
    {
        public Motocykl(double maxRychlost) : base("motroka", TypPohonu.Elektromotor, maxRychlost, 2)
        {
            MaxRychlost = maxRychlost;
        }

        public override string Natankuj()
        {
            return "Plním nádrž benzínem";
        }
    }

  


    abstract class Automobil : DopravniProstredek
    {
        public Automobil(TypPohonu pohon, double maxRychlost, int pocetMist) : base("automobil", pohon, maxRychlost, pocetMist)
        {
            MaxRychlost = maxRychlost;
            PocetMist = pocetMist;
            Pohon = pohon;
        }
    }

    sealed class DieselAuto : Automobil
    {
        public DieselAuto( double maxRychlost, int pocetMist) : base(TypPohonu.Spalovaci, maxRychlost, pocetMist)
        {
            MaxRychlost = maxRychlost;
            PocetMist = pocetMist;
        }
        public override string Natankuj()
        {
            return "Plním nádrž naftou";
        }
    }

    sealed class ElektroAuto : Automobil
    {
        public ElektroAuto(double maxRychlost, int pocetMist) : base(TypPohonu.Elektromotor, maxRychlost, pocetMist)
        {
            MaxRychlost = maxRychlost;
            PocetMist = pocetMist;
        }
        public override string Natankuj()
        {
            return "Připojuji na nabíječku";
        }
    }
    sealed class Bicykl : DopravniProstredek
    {
        public Bicykl( double maxRychlost) : base("bicykl", TypPohonu.Manualni, maxRychlost, 2)
        {
            MaxRychlost = maxRychlost;
        }
        public override string Natankuj()
        {
            return "jdu na svačinu";
        }
    }
    sealed class Flotila
    {
        List<DopravniProstredek> prostredek = new List<DopravniProstredek>();



        public int Velikost => prostredek.Count;

       
        public int Kapacita => prostredek.Sum(v => v.PocetMist);
            


        public void PridejVozidlo(DopravniProstredek z)
        {
            if (prostredek.Contains(z))
            {
                throw new ArgumentOutOfRangeException();
            }
            prostredek.Add(z);
        }

        public void OdeberVozidlo(DopravniProstredek d)
        { 
            if(prostredek.Contains(d))
            {
                prostredek.Remove(d);
            }
            throw new ArgumentOutOfRangeException();
        }

        public void Natankuj()
        {
            foreach(var z in prostredek)
            {
                z.Natankuj();
            }
        }

    }
}
