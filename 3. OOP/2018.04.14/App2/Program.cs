using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Square
            Console.Write("Square Side A = ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Area = {0}", Geometry.SquareArea(a));
            Console.WriteLine("Perimeter = {0}", Geometry.SquarePerimeter(a));

            // Rectangle
            Console.Write("Rectangle Side A = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Rectangle Side B = ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Area = {0}", Geometry.RectangleArea(b,c));
            Console.WriteLine("Perimeter = {0}", Geometry.RectanglePerimeter(b,c));

            // Circle
            Console.Write("Circle Radius = ");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("Area = {0}", Geometry.CircleArea(r));
        }
    }
}
