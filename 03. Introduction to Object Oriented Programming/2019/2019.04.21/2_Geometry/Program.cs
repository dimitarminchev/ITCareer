using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            // Квадрат
            Console.Write("Square side: ");
            var side = double.Parse(Console.ReadLine());
            var p = Geometry.SquarePerimeter(side);
            var s = Geometry.SquareArea(side);
            Console.WriteLine("Square Perimeter = {0}", p);            
            Console.WriteLine("Square Area = {0}", s);

            // Правоъгълник
            Console.Write("Rectangle sides [a,b]: ");
            var sides = Console.ReadLine().Split().Select(double.Parse).ToArray();
            p = Geometry.RectanglePerimeter(sides[0], sides[1]);
            s = Geometry.RectangleArea(sides[0],sides[1]);
            Console.WriteLine("Rectangle Perimeter = {0}", p);
            Console.WriteLine("Rectangle Area = {0}", s);

            // Кръг
            Console.Write("Circle Radius: ");
            var r = double.Parse(Console.ReadLine());
            s = Geometry.CircleArea(r);
            Console.WriteLine("Circle Area = {0}", s);
        }
    }
}
