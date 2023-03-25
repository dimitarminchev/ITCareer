namespace TransportPrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var km = long.Parse(Console.ReadLine());
            var t = Console.ReadLine();
            double price = 0;

            if (km < 20 && t == "day") price = 0.7 + km * 0.79;
            else if (km < 20 && t == "night") price = 0.7 + km * 0.9;
            else if (km >= 20 && km < 100) price = km * 0.09;
            else if (km >= 100) price = km * 0.06;

            Console.WriteLine(price);
        }
    }
}