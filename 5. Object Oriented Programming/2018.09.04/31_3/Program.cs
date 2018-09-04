using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_3
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
            Box<string>[] strings = new Box<string>[n];
            for(int i =0; i < n; i++)
            {
                strings[i] = new Box<string>();
                strings[i].Add(Console.ReadLine());
            }
            foreach (var item in strings)
            {
                WriteLine(item.ToString());
            }
        }
    }
}
