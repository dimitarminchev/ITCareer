using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _322
{
    // 3.2.2. Наредени двойки
    class Program
    {
        // O(n^2)
        static void Main(string[] args)
        {
            // O(1)
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            // O(n^2)
            for (int p = 1; p <= m; p++) // 2 + 2*n
            {
                for (int q = 1; q <= n; q++) // 2 + 2*n
                {
                    Console.WriteLine($"{p} {q}"); // (2*n)*(2*n) = 4*n^2 ~ O(n^2)
                }
            }
        }
    }
}
