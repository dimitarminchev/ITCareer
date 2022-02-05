/// <summary>
/// Refactoring Task "Matrix" Namespace.
/// </summary>
namespace Matrix
{
    /// <summary>
    /// Refactoring Task "Matrix" program class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Refactoring Task "Matrix" main program method.
        /// </summary>
        /// <param name="args">Given arguments</param>
        public static void Main(string[] args)
        {
            Console.Write("Enter a positive number: "); // 6
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
