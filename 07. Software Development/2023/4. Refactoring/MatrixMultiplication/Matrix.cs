/// <summary>
/// Refactoring Task "Matrix Multiplication" namespace.
/// </summary>
namespace MatrixMultiplication
{
    // <summary>
    /// Refactoring Task "Matrix Multiplication" class "Matrix"
    /// </summary>
    public static class Matrix
    {
        /// <summary>
        /// Print any dimmension matrix
        /// </summary>
        /// <param name="matrixToPrint">The Matrix To Print</param>
        public static void Print(double[,] matrixToPrint)
        {
            for (int x = 0; x < matrixToPrint.GetLength(0); x++)
            {
                for (int y = 0; y < matrixToPrint.GetLength(1); y++)
                {
                    Console.Write(matrixToPrint[x, y] + " ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// This method multiplyes two matrixes.
        /// </summary>
        /// <param name="firstMatrix">First Martrix to Multiply</param>
        /// <param name="secondMatrix">Second Martrix to Multiply</param>
        /// <returns>Matrix Multiplication</returns>
        /// <exception cref="Exception">Matrix dimmensions not mached.</exception>
        public static double[,] Product(double[,] firstMatrix, double[,] secondMatrix)
        {
            if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0))
            {
                throw new Exception("Error!");
            }

            var firstMatrixLength = firstMatrix.GetLength(1);
            var resultMatrix = new double[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];

            for (int x = 0; x < resultMatrix.GetLength(0); x++)
                for (int y = 0; y < resultMatrix.GetLength(1); y++)
                    for (int diff = 0; diff < firstMatrixLength; diff++)
                        resultMatrix[x, y] += firstMatrix[x, diff] * secondMatrix[diff, y];

            return resultMatrix;
        }
    }
}
