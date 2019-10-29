using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ColoredFigure
{
    // Base Class
    public abstract class ColoredFigure
    {
        protected string color;

        protected double size;

        public ColoredFigure(string color, double size)
        {
            this.color = color;
            this.size = size;
        }

        public void Show()
        {
            Console.WriteLine(string.Format("Color: {0}", this.color));
            Console.WriteLine(string.Format("Size: {0}", this.size));
        }

        public abstract string GetName();

        public abstract double GetArea();
    }
}
