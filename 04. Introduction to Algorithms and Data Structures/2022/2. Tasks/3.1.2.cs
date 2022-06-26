using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _312
{
    class Program
    {
        // 3.1.2. Метод Insert 
        // O(n) + O(1) + O(n) + O(n) = O(n)
        static void Main(string[] args)
        {
            // T(3 * n + 3) = O(n)
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            // T(4) = O(1)
            int number = int.Parse(Console.ReadLine());

            // 2 + 1 + ( (3 * n - 2) + (n + n - 1) + 3) ~ T(5*n + 3) = O(n)
            bool inserted = false; // 2
            List<int> newList = new List<int>(); // 1
            foreach (var item in list) // n
            {
                if (inserted) // 3 * n - 2 
                {
                    newList.Add(item); // n - 1
                    continue; // n - 1
                }
                if (number > item) newList.Add(item); // n + n - 1
                else // 3
                {
                    newList.Add(number); // 1
                    newList.Add(item); // 1
                    inserted = true; // 1
                }      
            }

            // O(n)
            Console.WriteLine(string.Join(" ", newList));
        }
    }
}
