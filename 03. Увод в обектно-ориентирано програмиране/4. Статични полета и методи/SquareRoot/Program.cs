namespace SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                var value = SquareRootPrecalculator.GetSqrt(number);
                Console.WriteLine(value);
            }
        }
    }
}