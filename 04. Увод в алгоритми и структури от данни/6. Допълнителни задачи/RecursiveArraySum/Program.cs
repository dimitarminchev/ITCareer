namespace RecursiveArraySum
{
    internal class Program
    {
        private static int Sum(int[] array, int index)
        {
            int sum = 0;
            if (index <= 0) return 0;
            return Sum(array, index - 1) + array[index - 1];
        }

        public static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(Sum(array, array.Length));
        }
    }
}