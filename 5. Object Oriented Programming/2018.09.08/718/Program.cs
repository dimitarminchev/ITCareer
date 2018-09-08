using System;
using System.Collections.Generic;
using System.Linq;

namespace _718
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Predicate<int> isEven = x => x % 2 == 0;
            Func<List<int>, List<int>> Sort = x =>
            {
                for (int i = 0; i < x.Count - 1; i++)
                {
                    for (int k = i; k < x.Count - 1; k++)
                    {
                        if (x[k + 1] < x[k])
                        {
                            int swap = x[k];
                            x[k] = x[k + 1];
                            x[k + 1] = swap;
                        }
                    }
                }
                return x;
            };
            Action<int[]> sortByOddEven = x =>
            {
                List<int> odd = new List<int>();
                List<int> even = new List<int>();
                for (int i = 0; i < x.Length; i++)
                {
                    if (isEven(x[i])) even.Add(x[i]);
                    else odd.Add(x[i]);
                }
                odd = Sort(odd);
                even = Sort(even);
                int index = 0;
                foreach (var num in even)
                {
                    x[index] = num;
                    index++;
                }
                foreach (var num in odd)
                {
                    x[index] = num;
                    index++;
                }
            };

            sortByOddEven(numbers);
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
