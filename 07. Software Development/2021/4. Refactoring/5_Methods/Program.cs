using System;

namespace _5_Methods
{
    // My Namespace
    using Methods;

    /// <summary>
    /// Methods main program class.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Methods main program method.
        /// </summary>
        static void Main(string[] args)
        {
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

            //Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            //peter.OtherInfo = "From Sofia, born at 17.03.1992";

            //Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            //stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";

            //Console.WriteLine("{0} older than {1} -> {2}",
            //    peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));

        }
    }
}
