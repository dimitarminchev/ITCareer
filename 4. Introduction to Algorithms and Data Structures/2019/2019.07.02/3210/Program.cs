using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3210
{
    class Program
    {
        // Problem 10. Филтриране на нечетен броя срещания
        static void Main(string[] args)
        {
            // 4 2 2 5 2 3 2 3 1 5 2
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();

            // Number Count
            int[] counter = new int[10];
            for (int i = 0; i < counter.Length; i++)
            {
                counter[i] = 0;
            }
            for (int i = 0; i < list.Count; i++)
            {
                counter[list[i]]++;
            }

            // Process
            Queue<int> queue = new Queue<int>();
            foreach (var item in list)
            {
                if (counter[item] % 2 == 0)
                {
                    queue.Enqueue(item);
                }
            }

            // Print: 5 3 3 5
            Console.WriteLine(string.Join(" ", queue));
        }
    }
}
