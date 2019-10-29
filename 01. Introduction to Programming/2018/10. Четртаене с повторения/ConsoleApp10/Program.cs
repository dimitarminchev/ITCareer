using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10. Димант
            int n = int.Parse(Console.ReadLine());

            // Top
            var left = (n - 1) / 2;
            for (int i = 1; i <= (n - 1) / 2; i++)
            { 
                Console.Write(new string('-', left));
                Console.Write("*");
                var mid = n - 2 * left - 2;
                if (mid >= 0)
                {
                    Console.Write(new string('-', mid));
                    Console.Write("*");
                }
                Console.WriteLine(new string('-', left));
                left--;
            }
            // Bottom
            for (int i = 1; i <= (n - 1) / 2; i++)
            {
                Console.Write(new string('-', left));
                Console.Write("*");
                var mid = n - 2 * left - 2;
                if (mid >= 0)
                {
                    Console.Write(new string('-', mid));
                    Console.Write("*");
                }
                Console.WriteLine(new string('-', left));
                left++;
            }
            // Top
            Console.Write(new string('-', left));
            Console.Write("*");
            Console.WriteLine(new string('-', left));
        }
    }
}
