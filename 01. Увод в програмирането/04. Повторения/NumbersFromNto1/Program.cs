namespace NumbersFromNto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int k = n; k > 0; k--)
            {
                Console.WriteLine(k);
            }
        }
    }
}