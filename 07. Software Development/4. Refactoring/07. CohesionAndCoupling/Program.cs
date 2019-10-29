using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// namespaces
using Files;
using Figure;

namespace _07.CohesionAndCoupling
{
    class Program
    {
        static void Main()
        {
            // Namespace: Files, Class: File
            Console.WriteLine(File.GetFileExtension("example"));
            Console.WriteLine(File.GetFileExtension("example.pdf"));
            Console.WriteLine(File.GetFileExtension("example.new.pdf"));
            Console.WriteLine(File.GetFileNameWithoutExtension("example"));
            Console.WriteLine(File.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(File.GetFileNameWithoutExtension("example.new.pdf"));

            // Namespace: Figure, Class: Cube
            Console.WriteLine("Distance in the 2D space = {0:f2}",
                Cube.Distance(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}",
                Cube.Distance(5, 2, -1, 3, -6, 4));

            Cube.Width = 3;
            Cube.Height = 4;
            Cube.Depth = 5;

            Console.WriteLine("Volume = {0:f2}", Cube.CalcVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", Cube.CalcDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", Cube.CalcDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", Cube.CalcDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", Cube.CalcDiagonalYZ());
        }
    }
}
