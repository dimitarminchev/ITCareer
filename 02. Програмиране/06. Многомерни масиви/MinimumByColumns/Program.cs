namespace MinimumByColumns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var line = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = line[col];
                }
            }

            int[] min = new int[cols];
            for (int col = 0; col < cols; col++)
            {
                min[col] = matrix[0, col];
                for (int row = 0; row < rows; row++)
                {
                    if (matrix[row, col] < min[col])
                    {
                        min[col] = matrix[row, col];
                    }
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write("{0, 8}", matrix[row, col]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Minimum:");
            for (int col = 0; col < cols; col++)
            {
                Console.Write("{0, 8}", min[col]);
            }
            Console.WriteLine();
        }
    }
}