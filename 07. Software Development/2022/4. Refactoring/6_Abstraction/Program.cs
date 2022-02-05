/// <summary>
/// Refactoring Task "Abstraction" Namespace.
/// </summary>
namespace Abstraction
{
    /// <summary>
    /// Refactoring Task "Abstraction" program class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Refactoring Task "Abstraction" main program method.
        /// </summary>
        /// <param name="args">Given arguments</param>
        public static void Main(string[] args)
        {
            // Circle 
            Circle circle = new Circle(5);
            circle.PrintInformation();

            // Rectangle 
            Rectangle rect = new Rectangle(2, 3);
            rect.PrintInformation();
        }
    }
}
