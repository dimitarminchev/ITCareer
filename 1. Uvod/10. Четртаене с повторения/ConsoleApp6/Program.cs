using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6. Ромбче от звездички
            int n = int.Parse(Console.ReadLine());
            // Top
            for (var row = 1; row <= n; row++)
            {
                for (var col = 1; col <= n - row; col++)
                    Console.Write(" ");
                Console.Write("*");
                for (var col = 1; col < row; col++)
                    Console.Write(" *");
                Console.WriteLine();
            }
            // Bottom
            for (var row = n - 1; row > 0; row--)
            {
                for (var col = 1; col <= n - row; col++)
                    Console.Write(" ");
                Console.Write("*");
                for (var col = 1; col < row; col++)
                    Console.Write(" *");
                Console.WriteLine();
            }
        }
    }
}
