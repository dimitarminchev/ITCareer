namespace MatrixInputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];

            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < cols; y++)
                {
                    matrix[x, y] = int.Parse(Console.ReadLine());
                }
            }

            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < cols; y++)
                {
                    Console.Write("{0, 4}", matrix[x, y]);
                }
                Console.WriteLine();
            }
        }
    }
}