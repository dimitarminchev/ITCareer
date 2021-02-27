using System;

namespace WalkinInMatrix
{
    /// <summary>
    /// Walkin in matrix main program class.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Walkin in matrix main program method.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("Enter a positive number: ");
            string input = Console.ReadLine();
            int n = 0;
            while (!int.TryParse(input, out n) || n < 0 || n > 100)
            {
                Console.WriteLine("You haven't entered a correct positive number!");
                input = Console.ReadLine();
            }

            Matrix matrix = new Matrix(n);
            matrix.GetAround();
            matrix.PrintMatrix();
        }
    }
}
