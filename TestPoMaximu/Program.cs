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



while (cekajiciZakaznici.Count > 0 && volneVoziky.Count > 0)
{
    int dobaNakupu = cekajiciZakaznici.Dequeue();
    int vozik = volneVoziky.Dequeue();
    if (!dobyPouziti.ContainsKey(vozik))
        dobyPouziti[vozik] = 0;
    dobyPouziti[vozik] += dobaNakupu;
    obsazeneVoziky.Add((minuta + dobaNakupu + 1, vozik));
}


var serazeneVoziky = dobyPouziti.OrderByDescending(v => v.Value);
Console.WriteLine("Vozík | Doba používání (minuty)");
foreach (var v in serazeneVoziky)
{
    Console.WriteLine($"{v.Key}     | {v.Value}");
}

