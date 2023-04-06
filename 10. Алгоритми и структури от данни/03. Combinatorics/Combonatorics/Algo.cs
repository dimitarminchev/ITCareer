namespace Combonatorics
{
    public static class Algo
    {
        // Permutation = Пермутации = O(N!)
        public static void PermuteNoRepeat<T>(T[] array, int index)
        {
            T[] vector = new T[array.Length];
            bool[] used = new bool[array.Length];
            PermuteNoRepeatAlgo(array, vector, used, index);
        }

        private static void PermuteNoRepeatAlgo<T>(T[] array, T[] vector, bool[] used, int index)
        {
            if (index >= vector.Length)
            {
                Console.WriteLine(string.Join(" ", vector));
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (!used[i])
                    {
                        used[i] = true;
                        vector[index] = array[i];
                        PermuteNoRepeatAlgo(array, vector, used, index + 1);
                        used[i] = false;
                    }
                }
            }
        }

        // Permutation with Repetition = Пермутации с повторения = O(N!)
        public static void PermuteRepeat<T>(T[] array, int index)
        {
            if (index >= array.Length)
            {
                Console.WriteLine(string.Join(" ", array));
            }
            else
            {
                PermuteRepeat(array, index + 1);
                for (int i = 0; i < array.Length; i++)
                {
                    Helper.Swap(array, index, i);
                    PermuteRepeat(array, index + 1);
                    Helper.Swap(array, index, i);
                }
            }
        }

        // Variation = Вариации = O(N!/(N-K)!)
        public static void Variations<T>(T[] array, int k)
        {
            var vector = new int[k];
            while (true)
            {
                VariationPrint(array, vector);
                var index = k - 1;
                while (index >= 0 && vector[index] == array.Length - 1)
                {
                    index--;
                }
                if (index < 0) break;
                vector[index]++;
                for (int i = index + 1; i < vector.Length; i++)
                {
                    vector[i] = 0;
                }
            }
        }

        private static void VariationPrint<T>(T[] array, int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write("{0} ", array[vector[i]]);
            }
            Console.WriteLine();
        }

        // Combination = Комбинации = O(N!/K!(N-K)!)
        public static void Combination<T>(T[] array, int k)
        {
            T[] vector = new T[k];
            CombinationAlgo(array, vector, 0, 0);
        }

        private static void CombinationAlgo<T>(T[] array, T[] vector, int index, int start)
        {
            if (index >= vector.Length)
            {
                Console.WriteLine(string.Join(" ", vector));
            }
            else
            {
                for (int i = start; i < array.Length; i++)
                {
                    vector[index] = array[i];
                    CombinationAlgo(array, vector, index + 1, i + 1);
                }
            }
        }

        // Combination with Repetition = Комбинации с повторения = O(N!/K!(N-K)!)
        public static void CombinationRepeat<T>(T[] array, int k)
        {
            T[] vector = new T[k];
            CombinationRepeatAlgo(array, vector, 0, 0);
        }

        private static void CombinationRepeatAlgo<T>(T[] array, T[] vector, int index, int start)
        {
            if (index >= vector.Length)
            {
                Console.WriteLine(string.Join(" ", vector));
            }
            else
            {
                for (int i = start; i < array.Length; i++)
                {
                    vector[index] = array[i];
                    CombinationAlgo(array, vector, index + 1, i);
                }
            }
        }

        // Binomial Coefficients = Биномни коефициенти =  C[n | k] = N!/(N-K)!K!
        public static long Binom(int k, int n)
        {
            if (k == 0 || k == n) return 1;
            return Binom(k - 1, n - 1) + Binom(k, n - 1);
        }
    }
}
