namespace Point
{
    public class Point : IComparable<Point>
    {
        private int X { get; set; }

        private int Y { get; set; }

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
