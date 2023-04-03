/// <summary>
/// Refactoring Task "Matrix Multiplication" namespace.
/// </summary>
namespace MatrixMultiplication
{
    /// <summary>
    /// Refactoring Task "Matrix Multiplication" main program class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Refactoring Task "Array Slider" main program method.
        /// </summary>
        /// <example>
        /// Output:
        /// 1 3
        /// 5 7
        /// *
        /// 4 2
        /// 1 5
        /// =
        /// 7 17
        /// 27 45
        /// </example>
        /// <param name="args">No arguments needed.</param>
        public static void Main(string[] args)
        {
            // 2x2
            double[,] A = new double[,] { { 1, 3 }, { 5, 7 } };
            double[,] B = new double[,] { { 4, 2 }, { 1, 5 } };
            double[,] C = Matrix.Product(A, B);

            // Print
            Matrix.Print(A);
            Console.WriteLine("*");
            Matrix.Print(B);
            Console.WriteLine("=");
            Matrix.Print(C);
        }
    }
}