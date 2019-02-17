using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraction;

namespace _06.Abstraction
{
    class Program
    {
        static void Main()
        {
            Circle circle = new Circle(5);
            circle.Print();

            Rectangle rectangle = new Rectangle(2, 3);
            rectangle.Print();
        }
    }
}
