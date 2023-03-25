namespace CelsiumToFahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Celsium = ");
            var Celsium = double.Parse(Console.ReadLine());
            var Fahrenheit = 1.8 * Celsium + 32;
            Console.WriteLine("Fahrenheit = {0}", Fahrenheit);
        }
    }
}