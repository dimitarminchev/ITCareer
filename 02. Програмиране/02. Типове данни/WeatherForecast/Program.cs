namespace WeatherForecast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var value = long.Parse(Console.ReadLine());

            if (value is sbyte)
            {
                Console.WriteLine("Sunny");
            }

            if (value is int)
            {
                Console.WriteLine("Cloudy");
            }

            if (value is long)
            {
                Console.WriteLine("Windy");
            }

            if (value is double)
            {
                Console.WriteLine("Rainy");
            }
        }
    }
}