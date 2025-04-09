namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var dbContext = new MyDbContext();
            var cars = dbContext.Cars.ToList();
            foreach(var car in cars)
            {
                Console.WriteLine($"{car.Id}");
            }
        }
    }
}
