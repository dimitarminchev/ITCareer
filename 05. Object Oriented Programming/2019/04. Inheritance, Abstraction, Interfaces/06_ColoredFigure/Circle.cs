using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ColoredFigure
{
    // Derivative Class
    public class Circle : ColoredFigure
    {
        public Circle(string color, double size) : base(color, size)
        {
            // nope
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(base.size, 2.0);
        }

        public override string GetName()
        {
            return "Circle";
        }
    }
}
