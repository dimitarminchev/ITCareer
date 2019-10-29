using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _531
{
    public class Rectangle : Shape
    {
        public int sideA { get; set; }
        public int sideB { get; set; }

        public Rectangle(int sideA, int sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }

        public override double CalculatePerimeter()
        {
            return this.sideA * 2 + this.sideB * 2;
        }

        public override double CalculateArea()
        {
            return this.sideA * this.sideB;
        }

        public sealed override string Draw()
        {
            return base.Draw() + "Rectangle";
        }
    }

}
