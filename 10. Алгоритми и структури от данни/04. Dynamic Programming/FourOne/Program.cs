namespace FourOne
{
    public class Program
    {
        public static long b(int n)
        {
            if (n <= 0) return 0;

            if (n == 1) return 2;

            else return 2 * b(n - 1) + b(n - 2) + b(n - 3);
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(b(n));
        }
    }
}