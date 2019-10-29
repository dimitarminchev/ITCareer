using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Sets
{
    class Program
    {
        // Задача за множествата
        static void Main(string[] args)
        {
            // Input
/*
1, 2, 3, 4, 5
4
1
2, 4
5
3
*/
            Console.Write("Universe: ");
            var universe = Console.ReadLine().Split
            (
                        new char[] { ',', ' ' },
                        StringSplitOptions.RemoveEmptyEntries
            ).Select(int.Parse).ToList();

            Console.Write("Subsets: ");
            List<List<int>> subsets = new List<List<int>>();
            var n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                subsets.Add
                (
                    Console.ReadLine().Split
                    (
                        new char[] { ',', ' ' }, 
                        StringSplitOptions.RemoveEmptyEntries
                    ).Select(int.Parse).ToList()
                );
                n--;
            }

            // Process
            Queue<List<int>> result = new Queue<List<int>>();

            var sortedSubsets = subsets.OrderByDescending(x => x.Count());
            foreach (var subset in sortedSubsets)
            {
                foreach (var item in subset)
                {
                    if (universe.Contains(item))
                    {
                        result.Enqueue(subset);
                        subset.ForEach(x => universe.Remove(x));
                        break;
                    }
                }
            }

            // Print
            Console.WriteLine("Probable Solution: ");
            foreach (var item in result)
            {
                Console.Write("{ ");
                Console.Write(string.Join(", ", item));
                Console.WriteLine(" }");
            }
        }
    }
}
