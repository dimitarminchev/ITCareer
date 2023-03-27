namespace PNumeralSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("System = ");
            int P = int.Parse(Console.ReadLine());
            var MIN = P;
            var MAX = Math.Pow(P, 2f) - 1f;
            var DIFF = MAX - MIN;
            Console.WriteLine("MIN = {0}", MIN);
            Console.WriteLine("MAX = {0}", MAX);
            Console.WriteLine("DIFF = {0}", DIFF);
        }
    }
}