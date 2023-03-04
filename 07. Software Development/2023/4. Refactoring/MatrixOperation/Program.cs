namespace MatrixOperation
{
    public class Program
    {
        /// <summary>
        /// Print Matrix
        /// </summary>
        private static void Matrix2x2Print(double[,] matrixToPrint)
        {
            for (int x = 0; x < matrixToPrint.GetLength(0); x++)
            {
                for (int y = 0; y < matrixToPrint.GetLength(1); y++)
                {
                    Console.Write(matrixToPrint[x, y] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Execute Matrix Operation
        /// </summary>
        private static double[,] Matrix2x2Product(double[,] firstMatrix, double[,] secondMatrix)
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

        /// <summary>
        /// Main program
        /// </summary>
        static void Main(string[] args)
        {
            double[,] A = new double[,] { { 1, 3 }, { 5, 7 } };
            double[,] B = new double[,] { { 4, 2 }, { 1, 5 } };
            double[,] C = Matrix2x2Product(A, B);

            // Print
            Matrix2x2Print(A);
            Console.WriteLine("*");
            Matrix2x2Print(B);
            Console.WriteLine("=");
            Matrix2x2Print(C);
        }

        
    }
}