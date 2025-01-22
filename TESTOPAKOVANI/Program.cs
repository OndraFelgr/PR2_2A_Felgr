namespace TESTOPAKOVANI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] cisla = { 1.3, 2.2, -1.5, 1.4, -2.7 };
            Console.WriteLine(PrumerNadLimitem(cisla, 1.1));
            Console.WriteLine(PrumerNadLimitem(cisla, -2));
            Console.WriteLine(PrumerNadLimitem(cisla, -3));

            
            double PrumerNadLimitem(double[] cisla, double limit)
            {
                double soucetCisel = 0;
                int pocetCisel = 0;
                for (int i = 0; i > cisla.Length; i++)
                {
                    if (cisla[i] < limit)
                    {
                        soucetCisel += cisla[i];
                        pocetCisel++;
                    }

                }
                return soucetCisel / pocetCisel;
            }
        }
       
    }
}
