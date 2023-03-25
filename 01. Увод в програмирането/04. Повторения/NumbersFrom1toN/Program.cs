namespace NumbersFrom1toN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int k = 1; k < n; k = k + 3)
            {
                Console.WriteLine(k);
            }
        }
    }
}