namespace Knapsack
{
    public class Program
    {

        /* Input:
        // Number of items (N)
        // Values (stored in array V)
        // Weights (stored in array W)
        // Knapsack Capacity (C)

        0-1 Knapsack Problem (Dynamic Programming)  Youtube Video:
        https://www.youtube.com/watch?v=xOlhR_2QCXY
        */
        const int N = 8; // Number of items
        static int[] V = new int[] { 0, 5, 3, 9, 1, 1, 2, 5, 2 }; // Values
        static int[] W = new int[] { 0, 3, 7, 6, 1, 2, 4, 5, 5 }; // Weights
        static int C = 7; // Knapsack Capacity

        static int result = 0;

        // Knapsack
        static int Knapsack(int n, int c)
        {
            if (n == 0 || c == 0) return 0;

            else if (W[n] > c) result = Knapsack(n - 1, C);
            else
            {
                var temp1 = Knapsack(n - 1, c);
                var temp2 = V[n] + Knapsack(n - 1, C - W[n]);
                result = Math.Max(temp1, temp2);
            }
            return result;
        }

        // Main Method
        static void Main(string[] args)
        {
            // Output
            Console.WriteLine("Number of items = {0}", N);
            Console.WriteLine("Values: {0}", string.Join(", ", V));
            Console.WriteLine("Weights: {0}", string.Join(", ", W));
            Console.WriteLine("Knapsack Capacity = {0}", C);

            // Knapsack Sum
            Console.WriteLine("Knapsack Sum = {0}", Knapsack(N, C));
        }
    }
}