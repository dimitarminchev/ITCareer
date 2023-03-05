using System;

/// <summary>
/// Refactoring Task "Abstraction" namespace.
/// </summary>
namespace Abstraction
{
    /// <summary>
    /// Class Rectangle
    /// </summary>
    public class Rectangle : Figure
    {
        /// <summary>
        /// Abstraction rectangle class default constructor
        /// </summary>
        public Rectangle() : base(0,0)
        {
            // nope
        }

        /// <summary>
        /// Abstraction rectangle class overloaded constructor
        /// </summary>
        /// <param name="w">Width</param>
        /// <param name="h">Height</param>
        public Rectangle(double w, double h) : base(w,h)
        {
            // nope
        }

        /// <summary>
        ///  Abstraction rectangle class calculate perimeter method.
        /// </summary>
        /// <returns>Perimeter</returns>
        public override double CalculatePerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        /// <summary>
        ///  Abstraction rectangle class calculate surface method.
        /// </summary>
        /// <returns>Surface</returns>
        public override double CalculateSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }

        /// <summary>
        ///  Abstraction rectangle class print information method.
        /// </summary>
        public override void PrintInformation()
        {
            Console.WriteLine
            (
                "I am a rectangle. My perimeter is {0:f2}. My surface is {1:f2}.",
                this.CalculatePerimeter(),
                this.CalculateSurface()
            );
        }
    }
}
