using System;

/// <summary>
/// Refactoring Task "Abstraction" namespace.
/// </summary>
namespace Abstraction
{
    /// <summary>
    /// Class Circle
    /// </summary>
    public class Circle : Figure
    {
        /// <summary>
        /// Abstraction circle class default constructor
        /// </summary>
        public Circle() : base(0)
        {
            // nope
        }

        /// <summary>
        ///  Abstraction circle class overloaded constructor
        /// </summary>
        /// <param name="radius">radius of the circle</param>
        public Circle(double radius) : base(radius)
        {
            // nope
        }

        /// <summary>
        /// Abstraction circle class calculate perimeter method.
        /// </summary>
        /// <returns>Perimeter</returns>
        public override double CalculatePerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        /// <summary>
        /// Abstraction circle class calculate surface method.
        /// </summary>
        /// <returns>Surface</returns>
        public override double CalculateSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }

        /// <summary>
        ///  Abstraction circle class print information method.
        /// </summary>
        public override void PrintInformation()
        {
            Console.WriteLine
            (
                "I am a circle. My perimeter is {0:f2}. My surface is {1:f2}.",
                this.CalculatePerimeter(),
                this.CalculateSurface()
            );
        }
    }
}
