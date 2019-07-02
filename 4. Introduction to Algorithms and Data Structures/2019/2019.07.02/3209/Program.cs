using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3209
{
    class Program
    {
        // Problem 9.	Филтриране
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            // 19 -10 12 -6 -3 34 -2 5
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();

            // Remove Negative Numbers 
            foreach (var item in list)
            {
                if (item > 0)
                {
                    queue.Enqueue(item);
                }
            }

            // Print: 19 12 34 5
            Console.WriteLine(string.Join(" ", queue));
        }
    }
}
