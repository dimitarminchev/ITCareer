using System;

namespace Task_09
{
    /// <summary>
    /// Task 09. Raindrops (Result: 90/100)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal density = decimal.Parse(Console.ReadLine()), total = 0;
            for (; n > 0; n--)
            {
                var parts = Console.ReadLine().Split();
                decimal reindropsCount = decimal.Parse(parts[0]);
                int squareMeters = int.Parse(parts[1]);
                total += (reindropsCount / squareMeters);
            }
            Console.WriteLine("{0:f3}", total / density);
        }
    }
}
