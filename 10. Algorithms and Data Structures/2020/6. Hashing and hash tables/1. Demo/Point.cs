using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace _1._Demo
{
    /// <summary>
    /// Точка в двумерна координатна система
    /// </summary>
    public class Point : IComparable<Point>
    {
        // Координати на токката в пространството
        private int X { get; set; }
        private int Y { get; set; }

        // Конструктор
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return string.Format("[{0},{1}]", this.X, this.Y);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Point) || (obj == null)) return false;
            Point p = (Point)obj;
            return (this.X == p.X) && (this.Y == p.Y);
        }

        public override int GetHashCode()
        {
            return (this.X << 16 | this.X >> 16) ^ this.Y;
        }


        public int CompareTo(Point other)
        {
            if (this.X != other.X) return this.X.CompareTo(other.X);
            else return this.Y.CompareTo(other.Y);
        }
    }
}
