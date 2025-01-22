namespace TestPoMaximu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vstup;
            int cislo;
            
            int nejvetsiCislo = Math.Min;
            List<int> list = new List<int>();
            
            Console.WriteLine(string.Join(", ", list)); 
            while (true)
            {
                Console.WriteLine("napis cele cislo");
                vstup = Console.ReadLine();

                if(vstup == "dost")
                {
                    break;
                }

                else if(int.TryParse(vstup, out cislo))
                {
                    if(cislo > nejvetsiCislo)
                    {
                        cislo += 
                        nejvetsiCislo = cislo;


                        
                    }
                }

                else
                {
                    Console.WriteLine("nebylo vloženo žádné číslo");
                }


            }
            Console.WriteLine("");
        }
    }
}
