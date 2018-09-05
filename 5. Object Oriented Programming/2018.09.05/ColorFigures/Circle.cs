using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorFigures
{
    public class Circle : ColoredFigure
    {
        public Circle(string color, int size) : base(color, size)
        {
            // nothing
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
