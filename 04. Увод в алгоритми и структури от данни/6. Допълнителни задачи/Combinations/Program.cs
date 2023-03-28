namespace Combinations
{
    internal class Program
    {
        private static void Combinations(int[] arr, int index, int start, int end)
        {
            if (index >= arr.Length)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write("{0} ", arr[i]);
                }
                Console.WriteLine();
                return; // Exit
            }
            else
            {
                for (int i = start; i <= end; i++)
                {
                    arr[index] = i;
                    Combinations(arr, index + 1, i, end);
                }
            }
        }

        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] arr = new int[k];
            Combinations(arr, 0, 1, n);
        }
    }
}