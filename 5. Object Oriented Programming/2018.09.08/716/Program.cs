using System;
using System.Collections.Generic;
using System.Linq;

namespace _716
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int divisor = int.Parse(Console.ReadLine());

            Predicate<int> isDivisionPossible = n => n % divisor == 0;

            Func<int[], int[]> Reverse = n =>
            {
                int[] x = new int[n.Length];
                int index = 0;
                for (int i = n.Length - 1; i >= 0; i--)
                {
                    x[index] = n[i];
                    index++;
                }
                return x;
            };

            Func<int[], int[]> Remove = n =>
            {
                List<int> x = n.ToList();
                for (int i = 0; i < x.Count(); i++)
                {
                    if (isDivisionPossible(x[i]))
                    {
                        x.Remove(x[i]);
                        i--;
                    }
                }
                return x.ToArray();
            };

            Console.WriteLine(string.Join(" ", Remove(Reverse(numbers))));
        }
    }
}
