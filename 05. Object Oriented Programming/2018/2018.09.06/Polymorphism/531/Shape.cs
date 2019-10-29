using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _531
{
    public abstract class Shape
    {
        public abstract double CalculatePerimeter();

        public abstract double CalculateArea();

        public virtual string Draw()
        {
            return "Drawing ";
        }
    }

}
