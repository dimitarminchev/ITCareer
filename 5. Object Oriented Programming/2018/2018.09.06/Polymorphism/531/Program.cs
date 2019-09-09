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
            Shape circle = new Circle(2.2);
            Shape rectangle = new Rectangle(2, 5);

            var listOfShapes = new List<Shape>();
            listOfShapes.Add(circle);
            listOfShapes.Add(rectangle);

            foreach (var shape in listOfShapes)
            {
                Console.WriteLine(shape.Draw());
                Console.WriteLine(shape.CalculatePerimeter());
                Console.WriteLine(shape.CalculateArea());
            }
/*
            // Circle
            Circle circle = new Circle(2.2);
            Console.WriteLine("Circle: Area = {0}, Perimeter = {1}", circle.CalculateArea(), circle.CalculatePerimeter());
            
            // Rectangle
            Rectangle rectangle = new Rectangle(2.5);
            Console.WriteLine("Rectangle: Area = {0}, Perimeter = {1}",rectangle.CalculateArea(), rectangle.CalculatePerimeter());
*/
        }
    }
}
