namespace Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sum = double.Parse(Console.ReadLine());
            var type = Console.ReadLine();
            if (sum <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");
                if (type == "summer") Console.WriteLine("Camp - {0:f2}", sum * 0.3);
                if (type == "winter") Console.WriteLine("Hotel - {0:f2}", sum * 0.7);
            }
            else if (sum <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");
                if (type == "summer") Console.WriteLine("Camp - {0:f2}", sum * 0.4);
                if (type == "winter") Console.WriteLine("Hotel - {0:f2}", sum * 0.8);
            }
            else
            {
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine("Hotel - {0:f2}", sum * 0.9);
            }
        }
    }
}