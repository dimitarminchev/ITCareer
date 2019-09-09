using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorFigures
{
    public abstract class ColoredFigure
    {
        protected string color;
        protected int size;
        public ColoredFigure(string color = "none", int size = 0)
        {
            this.color = color;
            this.size = size;
        }
        public void Show()
        {
            Console.WriteLine("Color: {0}\nSize: {1}", this.color, this.size);
        }
        public abstract string GetName();
        public abstract double GetArea();
    }
}
