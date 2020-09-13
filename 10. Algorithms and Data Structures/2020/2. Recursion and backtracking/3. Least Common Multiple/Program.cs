using System;

namespace _3._Least_Common_Multiple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a [Sample: 6]="); 
            int a = int.Parse(Console.ReadLine());
            Console.Write("b [Sample: 15]="); 
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Least Common Multiple [Sample: 30] = {0}", lcm(a, b)); // gcd = 7
        }

        // Метод за намиране на най-малко общо кратно
        private static int lcm(int a, int b)
        {
            return (a * b) / gcd(a, b);
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
