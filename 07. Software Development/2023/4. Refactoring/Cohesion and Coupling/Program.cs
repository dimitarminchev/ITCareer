using Cohesion_and_Coupling.Extensions;

/// <summary>
/// Refactoring Task "Cohesion and Coupling" namespace.
/// </summary>
namespace Cohesion_and_Coupling
{
    /// <summary>
    /// Refactoring Task "Cohesion and Coupling" main program class.
    /// </summary>
    public class Program
    {

        /// <summary>
        /// Refactoring Task "Cohesion and Coupling" main program method.
        /// </summary>
        /// <param name="args">No arguments needed.</param>
        public static void Main(string[] args)
        {
            // Example: FilesExtension
            Console.WriteLine(FilesExtension.GetFileExtension("example"));
            Console.WriteLine(FilesExtension.GetFileExtension("example.pdf"));
            Console.WriteLine(FilesExtension.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FilesExtension.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FilesExtension.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FilesExtension.GetFileNameWithoutExtension("example.new.pdf"));

            // Example: CoordinateSystem
            Console.WriteLine("Distance in the 2D space = {0:f2}",
                CoordinateSystem.CalculateDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}",
                CoordinateSystem.CalculateDistance3D(5, 2, -1, 3, -6, 4));

            CoordinateSystem.Width = 3;
            CoordinateSystem.Height = 4;
            CoordinateSystem.Depth = 5;
            Console.WriteLine("Volume = {0:f2}", CoordinateSystem.CalculateVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", CoordinateSystem.CalculateDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", CoordinateSystem.CalculateDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", CoordinateSystem.CalculateDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", CoordinateSystem.CalculateDiagonalYZ());
        }
    }
}

