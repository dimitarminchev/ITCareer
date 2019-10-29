using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {
        /* Алгоритъм за намиране на прости числа */
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());

            // v1 = О(N^2)
            for (int k = 2; k <= n; k++)
            {
                bool prime = true;
                for (int j = 2; j <= Math.Sqrt(k); j++) if (k % j == 0) prime = false;
                if (prime) Console.Write(k + " ");
            }

            // v2 = O(N*sqrt(N)) 
            for (int k=2;k<=n;k++)
            {
                bool prime = true; 
                for (int j = 2; j <= Math.Sqrt(k); j++) if (k % j == 0) prime = false;
                if (prime) Console.Write(k + " ");
            }
            
        }
    }
}
