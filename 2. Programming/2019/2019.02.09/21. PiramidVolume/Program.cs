using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.PiramidVolume
{
    class Program
    {
        // 21. Обем на пирамида 
        static void Main(string[] args)
        {
            // Code Refactoring
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());

            double volume = (length + width + height) / 3.0;
            Console.WriteLine("Pyramid Volume: {0:F2}", volume);

        }
    }
}
