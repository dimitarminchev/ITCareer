using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.TakeAndGo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int searchedNumber = int.Parse(Console.ReadLine());
            int border = Array.LastIndexOf(numbers, searchedNumber);
            int sum = 0;
            if (border == -1)
                Console.WriteLine("No occurances were found!");
            else
            {
                for (int i = 0; i < border; i++)
                    sum += numbers[i];
                Console.WriteLine(sum);
            }
        }
    }
}
