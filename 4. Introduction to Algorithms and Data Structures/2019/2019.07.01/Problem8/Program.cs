using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8
{
    // 1.2. Problem 5. Remove/Add Method 
    class Program
    {
        // O(n)
        static void Main(string[] args)
        {
            // O(n)
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> newList = new List<int>();
            newList.AddRange(list);

            // O(1)
            int number = int.Parse(Console.ReadLine());

            // O(n)
            if (list.Contains(number)) list.Remove(number);
            else newList.Add(number);
            newList.Sort();

            // 2 * O(n)
            Console.WriteLine(String.Join(" ", list));
            Console.WriteLine(String.Join(" ", newList));
        }
    }
}
