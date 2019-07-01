using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MaxPlayGround
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            var rows = int.Parse(Console.ReadLine());
            var cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                var line = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = line[col];
                }
            }
            
            // Find Max Sum
            int maxRow = 0, maxCol = 0;
            int maxSum = matrix[maxRow, maxCol];            
            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    var tempSum = matrix[row, col] +
                                  matrix[row, col + 1] +
                                  matrix[row + 1, col] +
                                  matrix[row + 1, col + 1];
                    if (tempSum > maxSum)
                    {
                        maxSum = tempSum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }

            // Print
            Console.WriteLine
            (
                "{0} {1}\n{2} {3}",
                matrix[maxRow, maxCol],
                matrix[maxRow, maxCol + 1],
                matrix[maxRow + 1, maxCol],
                matrix[maxRow + 1, maxCol + 1]
            );
        }
    }
}
