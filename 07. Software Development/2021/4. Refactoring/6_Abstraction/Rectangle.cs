using System;

namespace Abstraction
{
    /// <summary>
    /// Abstraction rectangle class
    /// </summary>
    class Rectangle : Figure
    {
        /// <summary>
        /// Abstraction rectangle class constructor
        /// </summary>
        public Rectangle()
            : base(0, 0)
        {
        }

        /// <summary>
        /// Abstraction rectangle class constructor
        /// </summary>
        /// <param name="width">Width</param>
        /// <param name="height">Height</param>
        public Rectangle(double width, double height)
            : base(width, height)
        {
        }

        /// <summary>
        /// Abstraction rectangle class calculate perimeter method.
        /// </summary>
        /// <returns>Perimeter</returns>
        public override double CalculatePerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        /// <summary>
        /// Abstraction rectangle class calculate surface method.
        /// </summary>
        /// <returns>Surface</returns>
        public override double CalculateSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }

        /// <summary>
        /// Abstraction rectangle class print information method.
        /// </summary>
        public override void PrintInformation()
        {
            Console.WriteLine("I am a rectangle. " +
                "My perimeter is {0:f2}. My surface is {1:f2}.", CalculatePerimeter(), CalculateSurface());
        }
    }
}
