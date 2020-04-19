using System;

namespace CohesionAndCoupling
{
    class Calculate
    {
        public static double Width { get; set; }
        public static double Height { get; set; }
        public static double Depth { get; set; }

        public static double Distance2D(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        public static double Distance3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
            return distance;
        }

        public static double Volume()
        {
            double volume = Width * Height * Depth;
            return volume;
        }

        public static double DiagonalXYZ()
        {
            double distance = Distance3D(0, 0, 0, Width, Height, Depth);
            return distance;
        }

        public static double DiagonalXY()
        {
            double distance = Distance2D(0, 0, Width, Height);
            return distance;
        }

        public static double DiagonalXZ()
        {
            double distance = Distance2D(0, 0, Width, Depth);
            return distance;
        }

        public static double DiagonalYZ()
        {
            double distance = Distance2D(0, 0, Height, Depth);
            return distance;
        }
    }
}
