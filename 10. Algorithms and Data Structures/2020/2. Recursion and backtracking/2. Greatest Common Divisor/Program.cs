using System;

namespace _2._Greatest_Common_Divisor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a [Sample: 35]=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b [Sample: 14]=");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Greatest Common Divisor [Sample: 7] = {0}", gcd(a, b)); // gcd = 7
        }

        // Рекурсивен метод за намиране на най-голям общ делител
        private static int gcd(int a, int b)
        {
            if (a == b) return a;
            if (a > b) return gcd(a - b, b);
            else return gcd(a, b - a);
        }
    }
}
