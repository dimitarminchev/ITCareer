using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
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
            Console.WriteLine("Binary Search for Number [-3] ...");
            if (Search.Binary(numbers, -3) == -1)
            {
                Console.WriteLine("Not Found");
            }
            else
            {
                Console.WriteLine("Found");
            }

            // Search for Char
            Console.WriteLine("Binary Search for Char ['z'] ...");
            if (Search.Binary(alphas, 'z') == -1)
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
