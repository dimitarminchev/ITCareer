using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Квадрат от звездички
            int n = int.Parse(Console.ReadLine());
            for (int r = 1; r <= n; r++)
            {
                Console.Write("*");
                for (int c = 1; c < n; c++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
