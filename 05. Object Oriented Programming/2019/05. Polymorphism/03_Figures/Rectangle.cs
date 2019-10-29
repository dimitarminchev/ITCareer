using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Figures
{
    // Derivative Class
    public sealed class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double calculateArea()
        {
            return this.height * this.width;
        }

        public override double calculatePerimeter()
        {
            return (this.width + this.height) * 2.0;
        }

        public override string Draw()
        {
            return base.Draw() + "Rectangle";
        }
    }
}
