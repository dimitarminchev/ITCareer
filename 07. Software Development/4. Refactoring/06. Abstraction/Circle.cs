using System;

namespace Abstraction
{
    class Circle : IFigure
    {
        protected double radius;

        public virtual double Radius
        {
            get { return radius; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Radius must be positive or zero");
                }
                radius = value;
            }
        }

        public Circle()
        {
            this.radius = 0;
        }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double Surface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }

        public override double Perimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        public override void Print()
        {
            Console.WriteLine("I am a circle. " +
                "My perimeter is {0:f2}. My surface is {1:f2}.",
                this.Perimeter(), this.Surface());
        }
    }
}
