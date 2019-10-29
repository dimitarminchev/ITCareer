using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ColoredFigure
{
    // Derivative Class
    public class Square : ColoredFigure
    {
        public Square(string color, double size) : base(color, size)
        {
            // nope
        }

        public override double GetArea()
        {
            return Math.Pow(base.size, 2.0);
        }

        public override string GetName()
        {
            return "Square";
        }
    }
}
