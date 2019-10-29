using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_4
{
    class Program
    {
        private static void WriteLine(string line)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(line);
            Console.ResetColor();
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<int>[] nums = new Box<int>[n];
            for (int i = 0; i < n; i++)
            {
                nums[i] = new Box<int>();
                nums[i].Add(int.Parse(Console.ReadLine()));
            }
            foreach (var item in nums)
            {
                WriteLine(item.ToString());
            }
        }
    }
}
