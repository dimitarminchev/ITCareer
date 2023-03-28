namespace ArrayReverse
{
    internal class Program
    {
        private static void Reverse(int[] numbers, int pos)
        {
            if (pos >= numbers.Count()) return;
            Reverse(numbers.Skip(1).ToArray(), pos++);
            Console.Write("{0} ", numbers[pos - 1]);
        }

        public static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Reverse(numbers, 0);
        }
    }
}