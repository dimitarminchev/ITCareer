namespace PyramidOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(m + " ");
                    m++;
                    if (m > n) return;
                }
                Console.WriteLine();
            }
        }
    }
}