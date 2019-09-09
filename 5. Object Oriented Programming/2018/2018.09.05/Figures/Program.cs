using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            var radius = int.Parse(Console.ReadLine());
            Drawable circle = new Circle(radius);

            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());
            Drawable rect = new Rectangle(width, height);

            circle.Draw();
            rect.Draw();

        }
    }
}
