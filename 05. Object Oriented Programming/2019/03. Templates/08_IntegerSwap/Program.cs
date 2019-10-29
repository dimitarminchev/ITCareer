using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_IntegerSwap
{
    class Program
    {
        // Integer Swap
        static void Main(string[] args)
        {
            // input
            int n = int.Parse(Console.ReadLine());
            IntegerSwap<int> integers = new IntegerSwap<int>(n);

            for (int i = 0; i < n; i++)
            {
                integers.Add(int.Parse(Console.ReadLine()));
            }
            var pos = Console.ReadLine().Split().ToArray();
            int first = int.Parse(pos[0]);
            int second = int.Parse(pos[1]);

            // output
            integers.Swap(first, second);
            integers.Print();
        }
    }
}
