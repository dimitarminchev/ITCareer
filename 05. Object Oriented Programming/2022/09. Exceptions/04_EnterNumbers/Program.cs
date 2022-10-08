namespace _04_EnterNumbers
{
    public class Program
    {
        /// <summary>
        /// Четене на числа от конзолата
        /// </summary>
        public static void ReadNumber(int start, int end)
        {
            int n = int.Parse(Console.ReadLine());
            if (n < start || n > end)
            {
                throw new InvalidOperationException($"Number must be in range from {start} to {end}");
            }
        }

        /// <summary>
        /// Главен метод
        /// </summary>
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                try
                {
                    ReadNumber(start, end);
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }
            }
        }
    }
}