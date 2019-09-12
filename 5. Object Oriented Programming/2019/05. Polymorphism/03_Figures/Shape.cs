using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Figures
{
    // Base Class
    public abstract class Shape
    {
        public abstract double calculatePerimeter();
        public abstract double calculateArea();

        public virtual string Draw()
        {
            return "Drawing ";
        }

    }
}
