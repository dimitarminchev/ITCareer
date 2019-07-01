using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    // 1.2. Problem 1. Намиране на най-малко число 
    class Program
    {
        // O(n) + O(1) + O(n) ~ O(n)
        static void Main(string[] args)
        {
            // T(3*n + 3) ~ O(n)
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            // T(3) ~ O(1)
            var minimum = list.First(); // 3

            // T(3 + (2*n-1) + 3*n) ~ O(n)
            for (int i = 1; i < list.Count; i++) // 3 + (n - 1) + (n - 1)
            {
                if (list[i] < minimum) // 3*n
                {
                    minimum = list[i]; 
                }
            }

            // O(1)
            Console.WriteLine(minimum);
        }
    }
}
