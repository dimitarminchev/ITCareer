using System;

namespace Abstraction
{
    abstract class Figure
    {
        private double width;
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

        public Figure()
        {
            this.height = 0;
            this.width = 0;
            this.radius = 0;
        }

        public Figure(double radius)
        {
            this.radius = radius;
        }

        public Figure(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public virtual double CalculatePerimeter()
        {
            return 0;
        }
        public virtual double CalculateSurface()
        {
            return 0;
        }

        public virtual void PrintInformation()
        {
            Console.WriteLine("My perimeter is {0:f2}. My surface is {1:f2}.", CalculatePerimeter(), CalculateSurface());
        }
    }
}
