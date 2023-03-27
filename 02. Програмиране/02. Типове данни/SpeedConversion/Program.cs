namespace SpeedConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var m = double.Parse(Console.ReadLine());
            var s = double.Parse(Console.ReadLine());
           
            var t = h * 3600 + m * 60 + s;
            var ms = n / t;
            var kmh = (n / 1000) / (t / 3600);
            var mp = (n / 1609) / (t / 3600);
            
            Console.WriteLine("{0:f6}", ms);
            Console.WriteLine("{0:f6}", kmh);
            Console.WriteLine("{0:f6}", mp);
        }
    }
}