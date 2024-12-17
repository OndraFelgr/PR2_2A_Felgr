namespace Dědičnost_Projekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }



    }


    abstract class Item
    {
        public string Name { get; set; }
        public int Durability { get; set; }
        public Rarita Rarity { get; set; }
        public TypZbrane GunClass { get; set; }

        public Item(string name, int durability, Rarita rarity, TypZbrane gunClass)
        {
            Name = name;
            Durability = durability;
            Rarity = rarity;
            GunClass = gunClass;
        }

        public abstract void Attack();
        public abstract void Upgrade();


        public override string ToString()
        {
            return $"Your{Name} is on {Durability} durability, has {Rarity} and this {GunClass} gun type ";
        }


    }

    sealed class Guns : Item
    {
        List<Guns> guns = new List<Guns>();
        protected Guns(string name, int durability, Rarita rarity, TypZbrane gunClass) : base(name, durability, rarity, gunClass)
        {
            Name = name;
            Durability = durability;
            Rarity = rarity;
            GunClass = gunClass;
        }

        public void AddGun()
        {
            
        }
        public override void Attack()
        {
            if(guns(z)
        }

        public override void Upgrade()
        {
            if(Rarity == Rarita.White)
            {
                Rarity = Rarita.Green;
            }
            if (Rarity == Rarita.Green)
            {
                Rarity = Rarita.Blue;
            }
            if (Rarity == Rarita.Blue)
            {
                Rarity = Rarita.Epic;
            }
            if (Rarity == Rarita.Epic)
            {
                Rarity = Rarita.Legendary;
            }
            if (Rarity == Rarita.Legendary)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
