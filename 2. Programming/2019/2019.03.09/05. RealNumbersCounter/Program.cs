using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.RealNumbersCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var counts = new SortedDictionary<double, int>();

            // 1. Count the numbers from the Array and put it into the Dictionary
            foreach (var key in nums)
            {
                if (counts.ContainsKey(key)) counts[key]++;
                else counts[key] = 1;
            }

            // 2. Print the counted numbers from the Dictionary
            foreach (var key in counts.Keys)
            {
                Console.WriteLine("{0} -> {1}", key, counts[key]);
            }
        }
    }
}
