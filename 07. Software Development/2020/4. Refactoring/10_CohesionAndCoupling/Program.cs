using System;

namespace CohesionAndCoupling
{
    class Program
    {
        static void Main()
        {
            // Files Demo
            Console.WriteLine("Files Extesions:");
            Console.WriteLine(GetFile.Extension("example"));
            Console.WriteLine(GetFile.Extension("example.pdf"));
            Console.WriteLine(GetFile.Extension("example.new.pdf"));
            Console.WriteLine();
            Console.WriteLine("File Names:");
            Console.WriteLine(GetFile.NameWithoutExtension("example"));
            Console.WriteLine(GetFile.NameWithoutExtension("example.pdf"));
            Console.WriteLine(GetFile.NameWithoutExtension("example.new.pdf"));

            // Cartesian Coordinates System Demo
            Console.WriteLine();
            Console.WriteLine("Cartesian Coordinates System ...");
            Console.WriteLine("Distance in the 2D space = {0:f2}",
                Calculate.Distance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}",
               Calculate.Distance3D(5, 2, -1, 3, -6, 4));

            Calculate.Width = 3;
            Calculate.Height = 4;
            Calculate.Depth = 5;
            Console.WriteLine("Volume = {0:f2}", Calculate.Volume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", Calculate.DiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", Calculate.DiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", Calculate.DiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", Calculate.DiagonalYZ());
        }
    }
}
