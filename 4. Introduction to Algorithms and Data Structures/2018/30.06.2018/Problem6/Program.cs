using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6
{
    class Program
    {
        /* Problem 6. Наредени двойки
            Определете сложността (максимания брой стъпки) на програма, 
            която чете от конзолата последователност от две цели числа m и n .
            Да се изведат всички въможни наредени двойки цели числа  ( p, q ) 
            които се менят съответно за p [1..m],  q в [1..n]
         */
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.WriteLine(i+" "+j);
                }
            }
            // Total: O(N^2)
        }
    }
}
