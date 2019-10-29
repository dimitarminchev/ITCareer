using System;

namespace Abstraction
{
    class Rectangle : IFigure
    {
        protected double width;

        public virtual double Width
        {
            get { return width; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Width must be positive or zero");
                }
                width = value;
            }
        }

        protected double height;

        public virtual double Height
        {
            get { return height; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Height must be positive or zero");
                }
                height = value;
            }
        }

        public Rectangle() 
        {
            this.height = 0;
            this.width = 0;
        }

        public Rectangle(double width, double height)            
        {
            this.width = width;
            this.height = height;
        }

        public override double Surface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }

        public override double Perimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        public override void Print()
        {
            Console.WriteLine("I am a rectangle. " +
                "My perimeter is {0:f2}. My surface is {1:f2}.",
                this.Perimeter(), this.Surface());
        }
    }
}
