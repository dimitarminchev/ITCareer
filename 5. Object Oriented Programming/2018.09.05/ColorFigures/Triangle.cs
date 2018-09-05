using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorFigures
{
    public class Triangle : ColoredFigure
    {
        public Triangle(string color, int size) : base(color, size)
        {
            // nothing
        }

        public override double GetArea()
        {
            return (Math.Pow(base.size, 2.0) * Math.Sqrt(3.0)) / 2.0;
        }

        public override string GetName()
        {
            return "Triangle";
        }
    }
}
