namespace Money
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var BTC = double.Parse(Console.ReadLine()) * 1168;
            var CNY = (double.Parse(Console.ReadLine()) * 0.15) * 1.76;
            var Total = (BTC + CNY) / 1.95;
            var Commission = (double.Parse(Console.ReadLine()) / 100) * Total;
            Console.WriteLine($"{Total - Commission:f2}");
        }
    }
}