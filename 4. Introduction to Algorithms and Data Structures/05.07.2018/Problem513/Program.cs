using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem513
{
    class Program
    {
        // Problem 513. Фибоначи търсене
        static void Main(string[] args)
        {
            // Input
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int key = int.Parse(Console.ReadLine());
            // Console.WriteLine(string.Join(" ", numbers));

            // Ouput
            Console.WriteLine(Helper.FibonacciSearch(numbers, numbers.Count(), key));
        }
    }
}
