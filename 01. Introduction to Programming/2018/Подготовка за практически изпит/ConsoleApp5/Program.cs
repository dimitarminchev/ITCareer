using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        // 5. Чертане на крепост
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.Write("/");
            Console.Write(new string('^', n / 2));
            Console.Write("\\");
            if (2 * n - (n / 2) * 2 - 4 > 0) Console.Write(new string('_', 2 * n - (n / 2) * 2 - 4));
            Console.Write("/");
            Console.Write(new string('^', n / 2));
            Console.WriteLine("\\");
            for (int i = 1; i <= n - 2; i++)
            {

                Console.Write("|");
                Console.Write(new string(' ', n / 2 + 1));
                if (i == n - 2 && 2 * n - (n / 2) * 2 - 4 > 0) Console.Write(new string('_', 2 * n - (n / 2) * 2 - 4));
                else Console.Write(new string(' ', 2 * n - (n / 2) * 2 - 4));
                Console.Write(new string(' ', n / 2 + 1));
                Console.WriteLine("|");
            }
            Console.Write("\\");
            Console.Write(new string('_', n / 2));
            Console.Write("/");
            if (2 * n - (n / 2) * 2 - 4 > 0) Console.Write(new string(' ', 2 * n - (n / 2) * 2 - 4));
            Console.Write("\\");
            Console.Write(new string('_', n / 2));
            Console.WriteLine("/");
        }
    }
}
