using System;

namespace _12_WalkinInMatrix
{
    class Program
    {
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
