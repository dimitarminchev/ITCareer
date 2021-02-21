using System;

namespace CohesionAndCoupling
{
    // My namespace
    using Extensions;

    class Program
    {
        static void Main(string[] args)
        {
            // FileExtesions
            Console.WriteLine(FileExtesions.GetFileExtension("example"));
            Console.WriteLine(FileExtesions.GetFileExtension("example.pdf"));
            Console.WriteLine(FileExtesions.GetFileExtension("example.new.pdf"));
            Console.WriteLine(FileExtesions.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileExtesions.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileExtesions.GetFileNameWithoutExtension("example.new.pdf"));

            // CoordinateSystems
            Console.WriteLine("Distance in the 2D space = {0:f2}", CoordinateSystems.CalculateDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}", CoordinateSystems.CalculateDistance3D(5, 2, -1, 3, -6, 4));
            CoordinateSystems.Width = 3;
            CoordinateSystems.Height = 4;
            CoordinateSystems.Depth = 5;
            Console.WriteLine("Volume = {0:f2}", CoordinateSystems.CalculateVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", CoordinateSystems.CalculateDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", CoordinateSystems.CalculateDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", CoordinateSystems.CalculateDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", CoordinateSystems.CalculateDiagonalYZ());
        }
    }
}
