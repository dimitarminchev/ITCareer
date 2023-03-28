namespace RecursiveFactorial
{
    internal class Program
    {
        private static long Factorial(int n)
        {
            if (n <= 0) return 1;
            else return n * Factorial(n - 1);
        }

        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(n));
        }
    }
}