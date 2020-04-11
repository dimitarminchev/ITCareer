using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    static class Cube
    {

        public static double Width { get; set; }
        public static double Height { get; set; }
        public static double Depth { get; set; }

        public static double Distance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        public static double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
            return distance;
        }

        public static double CalcVolume()
        {
            double volume = Width * Height * Depth;
            return volume;
        }

        public static double CalcDiagonalXYZ()
        {
            double distance = Distance(0, 0, 0, Width, Height, Depth);
            return distance;
        }

        public static double CalcDiagonalXY()
        {
            double distance = Distance(0, 0, Width, Height);
            return distance;
        }

        public static double CalcDiagonalXZ()
        {
            double distance = Distance(0, 0, Width, Depth);
            return distance;
        }

        public static double CalcDiagonalYZ()
        {
            double distance = Distance(0, 0, Height, Depth);
            return distance;
        }
    }
}
