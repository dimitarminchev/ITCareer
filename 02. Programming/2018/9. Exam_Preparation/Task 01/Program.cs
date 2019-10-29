using System;

namespace Task_01
{
    /// <summary>
    /// Task 01. Resurrection (Result: 100/100)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                long totalLength = int.Parse(Console.ReadLine());
                decimal totalWidth = decimal.Parse(Console.ReadLine());
                long wingLength = int.Parse(Console.ReadLine());
                decimal totalYears = (totalLength * totalLength) * (totalWidth + 2 * wingLength);
                Console.WriteLine(totalYears);
                n--;
            }
        }
    }
}
