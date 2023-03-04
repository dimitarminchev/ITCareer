namespace MatrixMultiplication
{
    internal class Program
    {
        static void Main(string[] args)
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
            Matrix.Print(C)
        }
    }
}