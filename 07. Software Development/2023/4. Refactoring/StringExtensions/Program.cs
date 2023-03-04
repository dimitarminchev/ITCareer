using System.Reflection.Metadata;

/// <summary>
/// Refactoring Task "StringExtensions" namespace.
/// </summary>
namespace StringExtensions
{
    /// <summary>
    /// Refactoring Task "StringExtensions" main program class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Refactoring Task "StringExtensions" main method.
        /// </summary>
        /// <example>
        /// b10a8db164e0754105b7a99be72e3fe5
        /// 4/3/2023 12:00:00 AM
        /// </example>
        /// <param name="args">No arguments needed.</param>
        static void Main(string[] args)
        {
            // demo
            Console.WriteLine(StringExtensions.ToMd5Hash("Hello World"));
            Console.WriteLine(StringExtensions.ToDateTime("4/3/2023"));
            // etc...
        }
    }
}