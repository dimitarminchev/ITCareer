namespace SquareFrame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            // Top
            Console.Write("+");
            for (int i = 0; i < n - 2; i++) Console.Write(" -");
            Console.WriteLine(" +");

            // Middle
            for (int row = 0; row < n - 2; row++)
            {
                Console.Write("|");
                for (int i = 0; i < n - 2; i++) Console.Write(" -");
                Console.WriteLine(" |");
            }

            // Bottom
            Console.Write("+");
            for (int i = 0; i < n - 2; i++) Console.Write(" -");
            Console.WriteLine(" +");
        }
    }
}