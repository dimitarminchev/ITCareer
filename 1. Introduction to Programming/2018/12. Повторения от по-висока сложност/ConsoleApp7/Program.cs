using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            // 7. Таблица с числа
            int n = int.Parse(Console.ReadLine());
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    int k = r + c + 1;
                    if (r + c + 1 > n) k = 2 * n - k;
                    Console.Write(k + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
