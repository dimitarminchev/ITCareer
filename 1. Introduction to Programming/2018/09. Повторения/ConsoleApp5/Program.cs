using System;
namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5. Най-голямо число
            var n = long.Parse(Console.ReadLine());
            long max = -10000000000000;
            for (int i = 0; i < n; i++)
            {
                var k = long.Parse(Console.ReadLine());
                if (k > max) max = k;
            }
            Console.WriteLine(max);
        }
    }
}
