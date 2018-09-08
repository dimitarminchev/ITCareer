using System;
using System.Linq;

namespace _714
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] borders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string oddOrEven = Console.ReadLine();

            Predicate<int> isOddOrEven = n => n % 2 == (oddOrEven == "Even" ? 0 : 1);


            for (int i = borders[0]; i <= borders[1]; i++)
            {
                if (isOddOrEven(i)) Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
