namespace hanojskavez
{


    internal class Program
    {
        static void Main(string[] args)
        {
            int discCount = 5;

            Puzzle p = new Puzzle(discCount);
            p.Solve();
        }
    }

    class Puzzle
    {
        public int DiscCount { get; private set; }

        Stack<int> LeftPin = new Stack<int>();
        Stack<int> MiddlePin = new Stack<int>();
        Stack<int> RightPin = new Stack<int>();

        public Puzzle(int discCount)
        {
            DiscCount = discCount;
            for (int i = discCount; i > 0; i--)
            {
                LeftPin.Push(i);
            }
        }

        public void Solve()
        {
            Transfer(DiscCount, LeftPin, RightPin, MiddlePin);
        }

        void Move(Stack<int> from, Stack<int> to)
        {
            if (from.Count < 1) return;

            if (to.Count > 0)
            {
                int fromDisc = from.Peek();
                int toDisc = to.Peek();
                if (toDisc < fromDisc) return;
            }

            int disc = from.Pop();
            to.Push(disc);
            Render();
        }

        void Transfer(int howMany, Stack<int> from, Stack<int> to, Stack<int> tmp)
        {
            if (howMany == 0) return;

            Transfer(howMany - 1, from, tmp, to);
            Move(from, to);
            Thread.Sleep(500);
            Transfer(howMany - 1, tmp, to, from);
        }

        void Render()
        {
            Console.Clear();
            RenderPin(LeftPin);
            RenderPin(MiddlePin);
            RenderPin(RightPin);
        }

        void RenderPin(Stack<int> pin)
        {

            int[] pinArray = pin.Reverse().ToArray();

            for (int i = DiscCount -1; i >= 0; i--)
            {
                if (i < pinArray.Length)
                {
                    int size = pinArray[i];
                    Console.WriteLine($"{new string(' ', DiscCount - size)}{new string('O', size * 2)}{new string(' ', DiscCount - size)}");
                }
                else
                {
                    Console.WriteLine($"{new string(' ', DiscCount)}{new string(' ', DiscCount)}");
                }
               
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}


    

