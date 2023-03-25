namespace UnitConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var e1 = Console.ReadLine();
            var e2 = Console.ReadLine();

            // Обюият брой проверки е 56!
            if (e1 == "m" && e2 == "mm") Console.WriteLine("{0} mm", n * 1000);
            if (e1 == "m" && e2 == "cm") Console.WriteLine("{0} cm", n * 100);
            if (e1 == "m" && e2 == "mi") Console.WriteLine("{0} mi", n * 0.000621371192);
            if (e1 == "m" && e2 == "in") Console.WriteLine("{0} in", n * 39.3700787);
            if (e1 == "m" && e2 == "km") Console.WriteLine("{0} km", n * 0.001);
            if (e1 == "m" && e2 == "ft") Console.WriteLine("{0} ft", n * 3.2808399);
            if (e1 == "m" && e2 == "yd") Console.WriteLine("{0} yd", n * 1.0936133);
        }
    }
}