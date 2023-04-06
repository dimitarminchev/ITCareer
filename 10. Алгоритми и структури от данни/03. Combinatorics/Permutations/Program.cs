namespace Permutations
{
    public class Program
    {
        // Permutations
        public static BigInteger Permutations(BigInteger n)
        {
            if (n <= 1) return 1;
            return n * Permutations(n - 1);
        }

        // Main program method
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Permutations = {0}", Permutations(n));
        }
    }
}