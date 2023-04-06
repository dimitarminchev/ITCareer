namespace Combonatorics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Структура данни
            var data1 = new string[] { "A", "B", "C" };
            var data2 = new int[] { 1, 2, 3 };

            // Permutation = Пермутации = O(N!)
            Console.WriteLine("1. Permutation without repetion ...");
            Algo.PermuteNoRepeat(data1, 0); // index = 0
            Algo.PermuteNoRepeat(data2, 0);

            // Permutation with Repetition = Пермутации с повторения = O(N!)
            Console.WriteLine("2. Permutation with repetition ...");
            Algo.PermuteRepeat(data1, 0); // index = 0
            Algo.PermuteRepeat(data2, 0);

            // Variation = Вариации = O(N! / (N - K)!)
            Console.WriteLine("3. Variation ...");
            Algo.Variations(data1, 2); // k = 2
            Algo.Variations(data2, 2);

            // Combination = Комбинации = O(N! / K!(N - K)!)
            Console.WriteLine("4. Combination ...");
            Algo.Combination(data1, 2); // k = 2
            Algo.Combination(data2, 2);

            // Combination with Repetition = Комбинации с повторения = O(N! / K!(N - K)!)
            Console.WriteLine("5. Combination with Repetition ...");
            Algo.CombinationRepeat(data1, 2); // k = 2
            Algo.CombinationRepeat(data2, 2);

            // Binomial Coefficients = Биномни коефициенти = C[n | k] = N! / (N - K)!K!
            Console.WriteLine("6. Binomial Coefficients ...");
            Console.WriteLine("[5/35] = {0}", Algo.Binom(5, 35));
            Console.WriteLine("[6/49] = {0}", Algo.Binom(6, 49));
        }
    }
}