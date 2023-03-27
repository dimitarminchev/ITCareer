namespace GeometryClass
{
    class Geometry
    {
        public static double SquarePerimeter(double side)
        {
            return side * 4.0;
        }

        public static double SquareArea(double side)
        {
            return side * side;
        }

        public static double RectanglePerimeter(double a, double b)
        {
            return 2 * (a + b);
        }

        public static double RectangleArea(double a, double b)
        {
            return a * b;
        }

        public static double CircleArea(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }
    }
}
