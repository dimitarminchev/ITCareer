using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _421
{/* 5 4 3 2 1*/
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Sort.Bubble(numbers);
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
