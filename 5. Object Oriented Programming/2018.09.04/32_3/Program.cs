using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_3
{
    class Program
    {
        private static void WriteLine(object line)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(line);
            Console.ResetColor();
        }

        static void Main(string[] args)
        {
            List<Box<int>> numbers = new List<Box<int>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                numbers.Add(new Box<int>(int.Parse(Console.ReadLine())));
            }
            int[] indexes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Swapper.Swap(numbers, indexes[0], indexes[1]);
            foreach (var item in numbers)
            {
                WriteLine(item);
            }
        }
    }
}
