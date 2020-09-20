using System;

namespace Knapsack_1._0
{
    class Program
    {
        const int N = 8; // Брой предмети
        const int C = 7; // Капацитет на раницата
        static int[] V = new int[] { 0, 5, 3, 9, 1, 1, 2, 5, 2 }; // Цени на предметите
        static int[] W = new int[] { 0, 3, 7, 6, 1, 2, 4, 5, 5 }; // Тегла на предметите
        static int result = 0; // Резултат

        // Раницата
        static int Knapsack(int n, int c)
        {
            if (n == 0 || c == 0) return 0;
            else if (W[n] > c) return Knapsack(n - 1, C);
            else 
            {
                var temp1 = Knapsack(n - 1, c);
                var temp2 = V[n] + Knapsack(n - 1, C - W[n]);
                result = Math.Max(temp1, temp2);
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Number of items = {0}", N);
            Console.WriteLine("Values: {0}", string.Join(", ",V));
            Console.WriteLine("Weights: {0}", string.Join(", ",W));
            Console.WriteLine("Knapsack Capacity = {0}", C);
            Console.WriteLine("Knapsack Sum = {0}", Knapsack(N,C));
        }
    }
}
