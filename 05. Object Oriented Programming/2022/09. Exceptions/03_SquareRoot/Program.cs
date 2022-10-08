namespace _03_SquareRoot
{
    internal class Program
    {
        /// <summary>
        /// Корен квадратен
        /// </summary>
        public static double Sqrt(double number)
        {
            if (number < 0)
            {
                throw new Exception("Invalid number.");
            }
            return Math.Sqrt(number);
        }

        /// <summary>
        /// Главен метод
        /// </summary>
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(Sqrt(-1));
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            finally
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}