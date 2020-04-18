using System;

namespace _09_Abstraction
{
    class Circle : Figure
    {
        public Circle() : base(0)
        {
        }
        public Circle(double radius) :  base(radius)
        {
        }
        public override double CalculatePerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }
        public override double CalculateSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }
        public override void PrintInformation()
        {
            Console.WriteLine("I am a circle. " +
                "My perimeter is {0:f2}. My surface is {1:f2}.", CalculatePerimeter(), CalculateSurface());
        }
    }
}
