using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_2
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
            List<Box<string>> strings = new List<Box<string>>();
            int n = int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                strings.Add(new Box<string>(Console.ReadLine()));
            }
            int[] indexes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Swapper.Swap(strings, indexes[0], indexes[1]);
            foreach(var item in strings)
            {
                WriteLine(item);
            }
        }
    }
}
