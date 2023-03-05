/// <summary>
/// Refactoring Task "Cohesion and Coupling.Extensions" namespace.
/// </summary>
namespace Cohesion_and_Coupling.Extensions
{
    /// <summary>
    /// Refactoring Task "Cohesion and Coupling" class Extensions.CoordinateSystem.
    /// </summary>
    public static class CoordinateSystem
    {
        public static double Width { get; set; }
        public static double Height { get; set; }
        public static double Depth { get; set; }

        /// <summary>
        /// Cohesion and coupling coordinate system calculate distance method in 2D.
        /// </summary>
        /// <param name="x1">x1</param>
        /// <param name="y1">y1</param>
        /// <param name="x2">x2</param>
        /// <param name="y2">y2</param>
        /// <returns></returns>
        public static double CalculateDistance2D(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        /// <summary>
        /// Cohesion and coupling coordinate system calculate distance method in 3D.
        /// </summary>
        /// <param name="x1">x1</param>
        /// <param name="y1">y1</param>
        /// <param name="z1">z1</param>
        /// <param name="x2">x2</param>
        /// <param name="y2">y2</param>
        /// <param name="z2">z2</param>
        public static double CalculateDistance3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
            return distance;
        }

        /// <summary>
        /// Cohesion and coupling coordinate system calculate volume method.
        /// </summary>
        /// <returns>Volume</returns>
        public static double CalculateVolume()
        {
            double volume = Width * Height * Depth;
            return volume;
        }

        /// <summary>
        /// Cohesion and coupling coordinate system calculate diagonal method.
        /// </summary>
        /// <returns>Diagonal</returns>
        public static double CalculateDiagonalXYZ()
        {
            double distance = CalculateDistance3D(0, 0, 0, Width, Height, Depth);
            return distance;
        }

        /// <summary>
        /// Cohesion and coupling coordinate system calculate diagonal method.
        /// </summary>
        /// <returns>Diagonal</returns>
        public static double CalculateDiagonalXY()
        {
            double distance = CalculateDistance2D(0, 0, Width, Height);
            return distance;
        }

        /// <summary>
        /// Cohesion and coupling coordinate system calculate diagonal method.
        /// </summary>
        /// <returns>Diagonal</returns>
        public static double CalculateDiagonalXZ()
        {
            double distance = CalculateDistance2D(0, 0, Width, Depth);
            return distance;
        }

        /// <summary>
        /// Cohesion and coupling coordinate system calculate diagonal method.
        /// </summary>
        /// <returns>Diagonal</returns>
        public static double CalculateDiagonalYZ()
        {
            double distance = CalculateDistance2D(0, 0, Height, Depth);
            return distance;
        }
    }
}
