namespace ZeroOne
{
    public class Program
    {
        /// <summary>
        /// Памет
        /// </summary>
        private static int[] memo;

        /// <summary>
        /// Редици 0/1
        /// </summary>
        private static int B(int k)
        {
            if (k <= 0) return 0;

            if (k == 1 || k == 2) return k + 1;

            if (memo[k] == 0)
            {
                memo[k] = B(k - 1) + B(k - 2);
            }
            return memo[k];
        }

        /// <summary>
        /// Главен метод
        /// </summary>
        public static void Main(string[] args)
        {
            int K = int.Parse(Console.ReadLine());

            memo = new int[K + 1];

            Console.WriteLine(B(K));
        }
    }
}