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
            // Input
            System.Console.Write("Enter range start: ");
            int start = int.Parse(Console.ReadLine());
            System.Console.Write("Enter range end: ");
            int end = int.Parse(Console.ReadLine());
            System.Console.WriteLine($"Enter 10 numbers in the range from {start} to {end}");

            // Process
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    ReadNumber(start, end);
                }
                catch (InvalidOperationException e)
                {
                    Console.Error($"Error: {e.Message}");
                }
                catch (Exception e)
                {
                    Console.Error($"Error: {e.Message}");
                }
            }

            // The End
        }
    }
}