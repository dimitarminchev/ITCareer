using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            // 8. Слънчеви очила
            var n = int.Parse(Console.ReadLine());

            // Print the top part
            Console.Write(new string('*', 2 * n));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', 2 * n));

            // print the middle part
            for (int i = 0; i < n - 2; i++)
            {
                // 1/2
                Console.Write("*");
                for (int j = 0; j < n * 2 - 2; j++)
                    Console.Write("/");
                Console.Write("*");

                // middle
                if (i == (n - 1) / 2 - 1)
                    Console.Write(new string('|', n));
                else
                    Console.Write(new string(' ', n));

                // 1/2
                Console.Write("*");
                for (int j = 0; j < n * 2 - 2; j++)
                    Console.Write("/");
                Console.WriteLine("*");
            }

            // Print the bottom part
            Console.Write(new string('*', 2 * n));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', 2 * n));

        }
    }
}
