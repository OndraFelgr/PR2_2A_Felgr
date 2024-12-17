namespace dd
{
    internal class Program
    {
      
            public static void Main(string[] args)
            {
                Clovek pepa = new Clovek("Josef", 95, 175);
                Clovek majka = new Clovek("Marie", 53, 162);
                Clovek jarda = new Clovek("Jaroslav", 120, 170);
                Clovek tonca = new Clovek("Antonie", 72, 178);
                Clovek kaja = new Clovek("Karel", 63, 178);
                Clovek tom = new Clovek("Tomáš", 94, 201);

                Clovek[] lide = { pepa, majka, jarda, tonca, kaja, tom };
                Array.Sort(lide);

                Console.WriteLine("Pole lidé po setřízení:");
                foreach (Clovek c in lide)
                    Console.WriteLine(c);
            }
        }
       
    
    class Clovek
    {
        public string Jmeno { get; private set; }
        public double Hmotnost { get; private set; }
        public double Vyska { get; private set; }
        public double bmi { get
            {
                return Hmotnost / Vyska;
            }
            private set; }
        public Clovek(string jmeno , double hmotnost, double vyska)
        {
            if (jmeno.Length < 1) throw new ArgumentException("Příliš krátké jméno");
            if (hmotnost <= 0) throw new ArgumentOutOfRangeException();
            if (vyska <= 0) throw new ArgumentOutOfRangeException();

            this.Jmeno = jmeno;
            this.Hmotnost = hmotnost;
            this.Vyska = vyska;
            this.bmi = bmi;
        }
    }
}
