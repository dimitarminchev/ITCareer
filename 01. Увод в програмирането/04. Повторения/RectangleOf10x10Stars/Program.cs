namespace RectangleOf10x10Stars
{
    internal class Program
    {
        static void Main(string[] args)
        static void Main(string[] args)
        {
            // v1
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(new string('*', 10));
            }

            // v2
            for (int row = 0; row < 10; row++)
            {
                for (int col = 0; col < 10; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}