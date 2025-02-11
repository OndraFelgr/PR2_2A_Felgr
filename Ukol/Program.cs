using System;
using System.Collections.Generic;
using System.Linq;
namespace ukol
{
    class Program
    {
        static Random random = new Random(123456);

        static void Main()
        {
            int pocetVoziku = 50;
            int casStart = 0;
            int casKonec = 12 * 60;
            int maxZakaznikuZaMinutu = 3;
            int minNakup = 5;
            int maxNakup = 45;

            Queue<int> volneVoziky = new Queue<int>(Enumerable.Range(0, pocetVoziku));
            Queue<int> cekajiciZakaznici = new Queue<int>();
            List<(int casNavratu, int vozik)> obsazeneVoziky = new List<(int, int)>();

            int[] dobaPouziti = new int[pocetVoziku];

            for (int minuta = casStart; minuta < casKonec; minuta++)
            {
                obsazeneVoziky.Sort((a, b) => a.casNavratu.CompareTo(b.casNavratu));
                for (int i = 0; i < obsazeneVoziky.Count; i++)
                {
                    if (obsazeneVoziky[i].casNavratu == minuta)
                    {
                        volneVoziky.Enqueue(obsazeneVoziky[i].vozik);
                    }
                }
                obsazeneVoziky.RemoveAll(v => v.casNavratu == minuta);

             
                int prichoziZakaznici = random.Next(maxZakaznikuZaMinutu + 1);
                for (int i = 0; i < prichoziZakaznici; i++)
                {
                    int dobaNakupu = random.Next(minNakup, maxNakup + 1);

                    if (volneVoziky.Count > 0)
                    {
                        int vozik = volneVoziky.Dequeue();
                        dobaPouziti[vozik] += dobaNakupu;
                        obsazeneVoziky.Add((minuta + dobaNakupu + 1, vozik));
                    }
                    else
                    {
                        cekajiciZakaznici.Enqueue(dobaNakupu);
                    }
                }

                
                
            }
          

        }
    }

}
