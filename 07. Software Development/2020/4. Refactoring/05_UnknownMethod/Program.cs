using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_UnknownMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrix1 = new double[,] { { 1, 3 },
                                    { 5, 7 } };
            var matrix2 = new double[,] { { 4, 2 },
                                      { 1, 5 } };
            var multiplicationResultMatrix = MyltiplyMatrices(matrix1, matrix2);

            for (int i = 0; i < multiplicationResultMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < multiplicationResultMatrix.GetLength(1); j++)
                {
                    Console.Write(multiplicationResultMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }

        }

        static double[,] MyltiplyMatrices(double[,] matrix1, double[,] matrix2)
        {
            if (matrix1.GetLength(1) != matrix2.GetLength(0))
            {
                throw new Exception("Matrices dimensions doesn't match for multiplication!");
            }

            var matrixCommonDimension = matrix1.GetLength(1);
            var productArray = new double[matrix1.GetLength(0), matrix2.GetLength(1)];
            for (int i = 0; i < productArray.GetLength(0); i++)
            {
                for (int j = 0; j < productArray.GetLength(1); j++)
                {
                    for (int multiplyIndex = 0; multiplyIndex < matrixCommonDimension; multiplyIndex++)
                    {
                        productArray[i, j] += matrix1[i, multiplyIndex] * matrix2[multiplyIndex, j];
                    }
                }
            }
            return productArray;
        }
    }
}
