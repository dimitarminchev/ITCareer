using System;

namespace _01_PointHashDemo
{
    public class Point : IComparable<Point>
    {
        public int X { get; set; }

        public int Y { get; set; }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return string.Format("[{0},{0}]", this.X, this.Y);
        }

        public override bool Equals(Object obj)
        {
            if (!(obj is Point) || (obj == null)) return false;
            Point p = (Point)obj;
            return (X == p.X) && (Y == p.Y);
        }

        public override int GetHashCode()
        {
            return (X << 16 | X >> 16) ^ Y;
        }

        public int CompareTo(Point otherPoint)
        {
            if (X != otherPoint.X)
            {
                return this.X.CompareTo(otherPoint.X);
            }
            else
            {
                return this.Y.CompareTo(otherPoint.Y);
            }
        }
    }
}
