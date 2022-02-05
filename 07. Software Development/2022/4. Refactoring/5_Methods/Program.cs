/// <summary>
/// Refactoring Task "Methods" Namespace.
/// </summary>
namespace Methods
{
    /// <summary>
    /// Refactoring Task "Methods" program class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Refactoring Task "Methods" main program method.
        /// </summary>
        /// <param name="args">Given arguments</param>
        static void Main(string[] args)
        {
            // Tesing Methods
            Console.WriteLine(Methods.CalculateTriangleArea(3, 4, 5));
            Console.WriteLine(Methods.DigitToString(5));
            Console.WriteLine(Methods.FindMax(5, -1, 3, 2, 14, 2, 3));

            Methods.PrintAsNumber(1.3, "f");
            Methods.PrintAsNumber(0.75, "%");
            Methods.PrintAsNumber(2.30, "r");

            bool horizontal, vertical;
            Console.WriteLine(Methods.CalculateDistance(3, -1, 3, 2.5, out horizontal, out vertical));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);
        }
    }
}
