namespace GreatestCommonDivisor
{
    public class Program
    {
        // Greatest Common Divisor (GCD)
        public static int GCD(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }

        // Main program method
        static void Main(string[] args)
        {
            int a = 35, b = 14;
            int gcd = GCD(a, b);
            Console.WriteLine(gcd);
        }
    }
}