using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _531
{
    class Program
    {
        static void Main(string[] args)
        {
            // Circle
            Circle circle = new Circle(15);
            Console.WriteLine("Circle: Area = {0}, Perimeter = {1}",
                                circle.CalculateArea(), circle.CalculatePerimeter());
            // Rectangle
            Rectangle rectangle = new Rectangle(5,7);
            Console.WriteLine("Rectangle: Area = {0}, Perimeter = {1}",
                                rectangle.CalculateArea(), rectangle.CalculatePerimeter());
        }
    }
}
