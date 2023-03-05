using System;

/// <summary>
/// Refactoring Task "Abstraction" namespace.
/// </summary>
namespace Abstraction
{
    /// <summary>
    /// Abstract Class Figure
    /// </summary>
    public abstract class Figure
    {
        private double width;

        /// <summary>
        ///  Abstraction figure class Width property.
        /// </summary>
        public double Width
        {
            get { return width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width should not be negative");
                }
                width = value;
            }
        }

        private double height;

        /// <summary>
        ///  Abstraction figure class Height property.
        /// </summary>
        public double Height
        {
            get { return height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Heigth should not be negative");
                }
                height = value;
            }
        }

        private double radius;

        /// <summary>
        ///  Abstraction figure class Radius property.
        /// </summary>
        public double Radius
        {
            get { return radius; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Radius should not be negative");
                }
                radius = value;
            }
        }

        /// <summary>
        ///  Abstraction figure class constructor
        /// /summary>
        public Figure()
        {
            this.height = 0;
            this.width = 0;
            this.radius = 0;
        }

        /// <summary>
        /// Abstraction figure class constructor.
        /// </summary>
        /// <param name="radius">Radius</param>
        public Figure(double radius)
        {
            this.radius = radius;
        }

        /// <summary>
        /// Abstraction figure class constructor.
        /// </summary>
        /// <param name="width">Width</param>
        /// <param name="height">Height</param>
        public Figure(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        /// <summary>
        ///  Abstraction figure class calulate perimeter method.
        /// </summary>
        /// <returns>Perimeter</returns>
        public virtual double CalculatePerimeter()
        {
            return 0;
        }

        /// <summary>
        ///  Abstraction figure class calculate surface method.
        /// </summary>
        /// <returns>Surface</returns>
        public virtual double CalculateSurface()
        {
            return 0;
        }

        /// <summary>
        ///  Abstraction figure class print information method.
        /// </summary>
        public virtual void PrintInformation()
        {
            Console.WriteLine("My perimeter is {0:f2}. My surface is {1:f2}.", CalculatePerimeter(), CalculateSurface());
        }
    }
}
