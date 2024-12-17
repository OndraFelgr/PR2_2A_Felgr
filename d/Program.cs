namespace d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bod[] body =
         {
            new Bod(0, 1),
            new Bod(2, 0),
            new Bod(0, 0),
            new Bod(1, 1),
        };

            Array.Sort(body);

            foreach (Bod bod in body)
            {
                Console.WriteLine(bod);
            }
        }
    }
    class Bod : IComparable
    {
        int IComparable.CompareTo(object? obj)
        {
            if(obj != null && obj is Bod druhyBod)
            {
                if(VzdalenostOdStredu() < druhyBod.VzdalenostOdStredu())
                {
                    return 1;
                }
              else  if (VzdalenostOdStredu() > druhyBod.VzdalenostOdStredu())
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                throw new Exception("Cannot compare - invalid type");
            }
        }
        

        public double X { get; set; }
        public double Y { get; set; }

        public Bod(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return string.Format("Bod [{0};{1}]", this.X, this.Y);
        }

        public double VzdalenostOdStredu()
        {
            return Math.Sqrt(this.X * this.X + this.Y * this.Y);
        }

    }


}
