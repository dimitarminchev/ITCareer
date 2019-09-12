using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Knapsack
{
    class Program
    {

/* Input:
// Number of distinct items (n)
// Values (stored in array v)
// Weights (stored in array w)
// Knapsack capacity (W)
*/
        const int n = 8; // Number of distinct items
        static int[] v = new int[] { 0, 5, 3, 9, 1, 1, 2, 5, 2 }; // Values
        static int[] w = new int[] { 0, 3, 7, 6, 1, 2, 4, 5, 5 }; // Weights
        static int W = 7; // Knapsack capacity

        // Solution
        static int[,] value = new int[n + 1, W + 1];

        static int m(int i, int j)
        {
            if (i == 0 || j <= 0) return 0;

            if (value[i - 1, j] == -1)
                value[i - 1, j] = m(i - 1, j);

            if (w[i] < j)
                value[i, j] = value[i - 1, j];
            else
            {
                if (value[i - 1, j - w[i]] == -1)
                    value[i - 1, j - w[i]] = m(i - 1, j - w[i]);

                value[i, j] = Math.Max(value[i - 1, j], value[i - 1, j - w[i]] + v[i]);               
            }
            return value[i, j];
        }

        // Main Method
        static void Main(string[] args)
        {
            Console.WriteLine(m(n,W));
        }
    }
}
