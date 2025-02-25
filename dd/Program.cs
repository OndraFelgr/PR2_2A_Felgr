namespace dd
{
    internal class Program
    {

        public static void Main(string[] args)
        {

        }


       public class Tools
        {
            public static int FindMin(int[] nums)
            {
                int min = int.MaxValue;

                foreach(int num in nums)
                {
                    if (min > num)
                        min = num;
                }
                return min;
            }
        }
    }
}
