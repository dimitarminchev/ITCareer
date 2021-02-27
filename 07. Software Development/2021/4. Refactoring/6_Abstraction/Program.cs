using System;

namespace Abstraction
{
    /// <summary>
    ///  Abstraction main program class.
    /// </summary>
    class Program
    {
        /// <summary>
        ///  Abstraction main program method.
        /// </summary>
        static void Main(string[] args)
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
