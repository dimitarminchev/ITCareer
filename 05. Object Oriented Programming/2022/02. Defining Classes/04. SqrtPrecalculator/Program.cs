namespace _04._SqrtPrecalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            for (int i = 0; i < 50; i++)
            {
                var number = random.Next(1, 500);
                var sqrt = SquareRootPrecalculator.GetSqrt(number);
                Console.WriteLine("SquareRoot({0})={1}", number, sqrt);
            }
        }
    }
}