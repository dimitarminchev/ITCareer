namespace Permutations
{
    internal class Program
    {
        private static int n = int.Parse(Console.ReadLine());

        private static int[] loops = new int[n];

        private static void Permutations(int index)
        {
            if (index == loops.Length)
            {
                foreach (var item in loops)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
                return;
            }
            else
            {
                for (int i = 1; i <= loops.Length; i++)
                {
                    loops[index] = i;
                    Permutations(index + 1);
                }
            }
        }

        public static void Main(string[] args)
        {
            Permutations(0);
        }
    }
}