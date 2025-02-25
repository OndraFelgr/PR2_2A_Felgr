namespace Michacka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [1, 2, 3, 4, 5, 6, 7];
            Zamichej zamichej = new(nums);
            while(zamichej.Remaining > 0)
            {
                Console.WriteLine($"dalsi cislo je{zamichej.Next()}");
            }
        }
    }

    class Zamichej
    {
        int[] data;
        int index;
        Random random = new Random();
        public int Remaining => data.Length - index;
        public Zamichej(int[] data)
        {
            data = [.. data];
            Umichej();
        }

        private void Umichej()
        {
            index = 0;

            data = data.OrderBy(x => random.NextDouble()).ToArray();
        }
        public int Next()
        {
            if(Remaining > 0)
            {
                return data[index++];

            }
            else
            {
                throw new InvalidOperationException();
            }
        }
    }
}
