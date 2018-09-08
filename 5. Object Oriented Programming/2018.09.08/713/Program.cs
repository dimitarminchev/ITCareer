using System;
using System.Linq;

namespace _713
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> Min = n =>
            {
                int min = n[0];
                foreach (var number in n) if (number < min) min = number;
                return min;
            };

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(Min(numbers));
        }
    }
}
