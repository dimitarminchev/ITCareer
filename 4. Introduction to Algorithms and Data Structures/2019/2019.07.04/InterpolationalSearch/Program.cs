using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpolationalSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Data Structures
            var numbers = new int[] { -5, 5, -4, 4, -3, 3, -2, 2, -1, 1 };
            var alphas = new char[] { 'm', 'a', 'g', 'g', 'i', 'c', 'h', 'a', 'p', 'p', 'e', 'n', 'd', 's', 'h', 'e', 'r', 'e' };

            // Pre-Processing ... (Sort)
            numbers = numbers.OrderBy(item => item).ToArray();
            alphas = alphas.OrderBy(item => item).ToArray();

            // Search for Number
            Console.WriteLine("Interpolational Search for Number [-3] ...");
            if (Search.Interpolational(numbers, -3) == -1)
            {
                Console.WriteLine("Not Found");
            }
            else
            {
                Console.WriteLine("Found");
            }

            // Search for Char
            Console.WriteLine("Interpolational Search for Char ['z'] ...");
            if (Search.Interpolational(alphas, 'z') == -1)
            {
                Console.WriteLine("Not Found");
            }
            else
            {
                Console.WriteLine("Found");
            }
        }
    }
}
