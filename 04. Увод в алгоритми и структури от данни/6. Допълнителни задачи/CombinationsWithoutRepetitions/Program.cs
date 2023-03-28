namespace CombinationsWithoutRepetitions
{
    internal class Program
    {
        private static int n = int.Parse(Console.ReadLine());
        private static int k = int.Parse(Console.ReadLine());
        private static int[] arr = new int[k];

        private static void Combinations(int index, int border = 1)
        {
            if (index == arr.Length)
            {
                Console.WriteLine(String.Join(" ", arr));
                return;
            }
            else
            {
                for (int i = border; i <= n; i++)
                {
                    arr[index] = i;
                    Combinations(index + 1, i + 1);
                }
            }
        }

        public static void Main(string[] args)
        {
            Combinations(0);
        }
    }
}