namespace SmallShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine().ToLower();
            var town = Console.ReadLine().ToLower();
            var count = double.Parse(Console.ReadLine());
            if (town == "sofia")
            {
                if (product == "coffee") Console.WriteLine(0.5 * count);
                if (product == "water") Console.WriteLine(0.8 * count);
                if (product == "beer") Console.WriteLine(1.2 * count);
                if (product == "sweets") Console.WriteLine(1.45 * count);
                if (product == "peanuts") Console.WriteLine(1.6 * count);
            }
            if (town == "varna")
            {
                if (product == "coffee") Console.WriteLine(0.45 * count);
                if (product == "water") Console.WriteLine(0.7 * count);
                if (product == "beer") Console.WriteLine(1.1 * count);
                if (product == "sweets") Console.WriteLine(1.35 * count);
                if (product == "peanuts") Console.WriteLine(1.55 * count);
            }
            if (town == "plovdiv")
            {
                if (product == "coffee") Console.WriteLine(0.4 * count);
                if (product == "water") Console.WriteLine(0.7 * count);
                if (product == "beer") Console.WriteLine(1.15 * count);
                if (product == "sweets") Console.WriteLine(1.3 * count);
                if (product == "peanuts") Console.WriteLine(1.5 * count);
            }
        }
    }
}