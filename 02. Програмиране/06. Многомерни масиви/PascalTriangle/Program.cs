namespace PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                int h = int.Parse(Console.ReadLine());

                long[][] triangle = new long[h + 1][];
                for (int row = 0; row < h; row++)
                {
                    triangle[row] = new long[row + 1];
                }

                triangle[0][0] = 1;

                for (int row = 0; row < h - 1; row++)
                {
                    for (int col = 0; col <= row; col++)
                    {
                        triangle[row + 1][col] += triangle[row][col];
                        triangle[row + 1][col + 1] += triangle[row][col];
                    }
                }

                for (int row = 0; row < h; row++)
                {
                    Console.Write(new String(' ', 2 * (h - row)));
                    for (int col = 0; col <= row; col++)
                    {
                        Console.Write("{0,3} ", triangle[row][col]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }