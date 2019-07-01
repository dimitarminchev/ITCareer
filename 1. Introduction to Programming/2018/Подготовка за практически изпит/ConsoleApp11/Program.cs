using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        // 11. Пеперуда 
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            // Горна част
            for (int k = 1; k < n-1; k++)
            {
                var part1 = "";
                if (k % 2 != 0) part1 = new string('*', n - 2);
                if (k % 2 == 0) part1 = new string('-', n - 2);
                Console.WriteLine("{0}\\ /{1}", part1, part1);
            }
            // Среда
            var part2 = new string(' ', n - 1);
            Console.WriteLine("{0}@{1}", part2, part2);
            // Долна част
            for (int k = 1; k < n - 1; k++)
            {
                var part1 = "";
                if (k % 2 != 0) part1 = new string('*', n - 2);
                if (k % 2 == 0) part1 = new string('-', n - 2);
                Console.WriteLine("{0}/ \\{1}", part1, part1);
            }
        }
    }
}
