using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Figures
{
    class Program
    {
        // Task 3. Abstract & Sealed
        static void Main(string[] args) 
        {
            // Circle
            Shape circle = new Circle(3.0);
            Console.WriteLine(circle.Draw());
            Console.WriteLine("Area = {0:f2}", circle.calculateArea());
            Console.WriteLine("Perimeter = {0:f2}", circle.calculatePerimeter());

            // Rectangle
            Shape rect = new Rectangle(2.3,3.0);
            Console.WriteLine(rect.Draw()); 
            Console.WriteLine("Area = {0:f2}", rect.calculateArea());
            Console.WriteLine("Perimeter = {0:f2}", rect.calculatePerimeter());
        }
    }
}
