/// <summary>
/// Refactoring task "Methods" namespace.
/// </summary>
namespace Methods
{
    /// <summary>
    /// Refactoring task "Methods" main program class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Refactoring task "Methods" main program method.
        /// </summary>
        /// <param name="args">No arguments needed.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine(Methods.CalculateTriangleArea(3, 4, 5));

            Console.WriteLine(Methods.NumberToDigit(5));

            Console.WriteLine(Methods.FindMax(5, -1, 3, 2, 14, 2, 3));

            Methods.PrintAsNumber(1.3, "f");
            Methods.PrintAsNumber(0.75, "%");
            Methods.PrintAsNumber(2.30, "r");

            bool horizontal, vertical;
            Console.WriteLine(Methods.CalculateDistance(3, -1, 3, 2.5, out horizontal, out vertical));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            peter.OtherInfo = "From Sofia, born at 03/17/1992";

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            stella.OtherInfo = "From Vidin, gamer, high results, born at 11/03/1993";

            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}