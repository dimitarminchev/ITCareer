using System;
using System.Linq;

namespace _719
{
    class Program
    {
        static void Main(string[] args)
        {
            int border = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Func<int, int, int> GCD = (a, b) =>
            {
                while (a != b)
                {
                    if (a > b) a = a - b;
                    else b = b - a;
                }
                return a;
            };

            Func<int[], int> LCM = nums =>
            {
                int lcm = 1;
                foreach (var num in nums)
                {
                    lcm = lcm * num / GCD(lcm, num);
                }
                return lcm;
            };

            int leastCommonMultiple = LCM(numbers);

            Predicate<int> isMultipleOf = n => n % leastCommonMultiple == 0;

            for (int i = 1; i <= border; i++)
            {
                if (isMultipleOf(i)) Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
