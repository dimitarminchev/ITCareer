using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] bits = new int[n + 1];

            for (int i = 1; i <= n; i++)
            {
                bits[i] = bits[i / 2] + (i % 2);
            }

            Console.WriteLine(string.Join(" ", bits));
        }
    }
}
