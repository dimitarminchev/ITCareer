using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.LinqSumMiniMaxAvr
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            int n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();
            while (n > 0)
            {
                int next = int.Parse(Console.ReadLine());
                numbers.Add(next);
                n--;
            }
            // Print
            Console.WriteLine("Sum = {0}", numbers.Sum());
            Console.WriteLine("Min = {0}", numbers.Min());
            Console.WriteLine("Max = {0}", numbers.Max());
            Console.WriteLine("Average = {0}", numbers.Average());

        }
    }
}
