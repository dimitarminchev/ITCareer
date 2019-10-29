using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Figures
{
    // Derivative Class
    public sealed class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double calculateArea()
        {
            return Math.PI * Math.Pow(this.radius,2.0);
        }

        public override double calculatePerimeter()
        {
            return 2.0 * Math.PI * this.radius;
        }

        public override string Draw()
        {
            return base.Draw() + "Circle";
        }
    }
}
