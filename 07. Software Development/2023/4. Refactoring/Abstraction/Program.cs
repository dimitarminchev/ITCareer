/// <summary>
/// Refactoring Task "Abstraction" namespace.
/// </summary>
namespace Abstraction
{
    /// <summary> 
    /// Refactoring Task "Abstraction" main program class.
    /// </summary>
    public class Program
    {

        /// <summary>
        /// Refactoring Task "Abstraction" main program method.
        /// </summary>
        /// <param name="args">No arguments needed.</param>
        public static void Main(string[] args)
        {
            // Example: Circle
            Circle circle = new Circle(5);
            circle.PrintInformation();

            // Example: Rectangle
            Rectangle rectangle = new Rectangle(2, 3);
            rectangle.PrintInformation();
        }
    }
}