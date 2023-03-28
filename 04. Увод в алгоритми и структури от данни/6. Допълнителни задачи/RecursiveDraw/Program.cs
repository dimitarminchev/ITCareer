namespace RecursiveDraw
{
    internal class Program
    {
        private static void Draw(int n)
        {
            int c = n;
            if (n <= 1) Console.WriteLine(new string('*', n));
            else
            {
                Console.WriteLine(new string('*', n));
                Draw(n - 1);
            }
            if (c <= n) Console.WriteLine(new string('#', n));
        }

        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Draw(n);
        }
    }
}