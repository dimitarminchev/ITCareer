using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3211
{
    class Program
    {
        // Problem 11.	Честота на срещания
        static void Main(string[] args)
        {
            // 3 4 4 2 3 3 4 3 2
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();

            // Counter
            SortedDictionary<int, int> counter = new SortedDictionary<int, int>();
            foreach (var item in list)
            {
                if (counter.ContainsKey(item))
                {
                    counter[item]++;
                }
                else
                {
                    counter.Add(item, 1);
                }
            }

            // Print
            foreach (var item in counter.Keys)
            {
                Console.WriteLine("{0} -> {1}", item, counter[item]);
            }
            
        }
    }
}
