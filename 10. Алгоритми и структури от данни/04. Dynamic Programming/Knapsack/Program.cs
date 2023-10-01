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
        private static int memo = 0; // Памет
        private static int[] V; // цени
        private static int[] W; // тегла

        /// <summary>
        /// Раницата
        /// </summary>
        private static int Knapsack(int n, int c)
        {
            if (n == 0 || c == 0)
            {
                memo = 0;
            }
            else if (W[n] > c)
            {
                memo = Knapsack(n - 1, c);
            }
            else
            {
                memo = Math.Max
                (
                    Knapsack(n - 1, c),
                    V[n] + Knapsack(n - 1, c - W[n])
                );
            }
            return memo;
        }

        /// <summary>
        /// Главен метод
        /// </summary>
        public static void Main(string[] args)
        {
            // Брой предмети = 8
            int N = int.Parse(Console.ReadLine());

            // Тегла: 3, 7, 6, 1, 2, 4, 5, 5  
            W = new int[N + 1];
            W[0] = 0;
            Console.ReadLine().Split(",").Select(int.Parse).ToArray().CopyTo(W, 1);

            // Цени: 5, 3, 9, 1, 1, 2, 5, 2
            V = new int[N + 1];
            V[0] = 0;
            Console.ReadLine().Split(",").Select(int.Parse).ToArray().CopyTo(V, 1);

            // Капацитет на раницата = 7
            int C = int.Parse(Console.ReadLine());

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