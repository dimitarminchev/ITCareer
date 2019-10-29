using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            // Circle
            Console.Write("Radius = ");
            var radius = int.Parse(Console.ReadLine());
            IDrawable circle = new Circle(radius);

            // Rectangle
            Console.Write("Width = ");
            var width = int.Parse(Console.ReadLine());
            Console.Write("Height = ");
            var height = int.Parse(Console.ReadLine());
            IDrawable rect = new Rectangle(width, height);

            // Draw Figures
            circle.Draw();
            rect.Draw();
        }
    }
}
