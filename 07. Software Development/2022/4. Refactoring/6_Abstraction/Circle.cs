/// <summary>
/// Refactoring Task "Abstraction" Namespace.
/// </summary>
namespace Abstraction
{
    /// <summary>
    /// Abstraction circle class
    /// </summary>
    public class Circle : Figure
    {
        /// <summary>
        ///  Abstraction circle class constructor
        /// </summary>
        public Circle() : base(0)
        {
        }

        /// <summary>
        ///  Abstraction circle class constructor
        /// </summary>
        /// <param name="radius">radius of the circle</param>
        public Circle(double radius) : base(radius)
        {
        }

        /// <summary>
        ///  Abstraction circle class calculate perimeter method.
        /// </summary>
        /// <returns>Perimeter</returns>
        public override double CalculatePerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        /// <summary>
        ///  Abstraction circle class calculate surface method.
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
            Console.WriteLine("I am a circle. " +
                "My perimeter is {0:f2}. My surface is {1:f2}.", CalculatePerimeter(), CalculateSurface());
        }
    }
}
