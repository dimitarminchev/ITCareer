namespace SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            double result1 = 0;
            double result2 = 0;
            result1 = Math.Sqrt(15);
            try
            {
                result2 = CustomMath.Sqrt(-15);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine($"Original {result1}");
            Console.WriteLine($"Custom   {result2}");
        }
    }
}