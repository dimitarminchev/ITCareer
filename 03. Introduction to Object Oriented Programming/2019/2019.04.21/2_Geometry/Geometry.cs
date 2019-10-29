using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Geometry
{
    class Geometry
    {
        /// <summary>
        /// Периметър на квадрат
        /// </summary>
        /// <param name="side">Страна на квадрата</param>
        /// <returns>Периметър</returns>
        public static double SquarePerimeter(double side)
        {
            return side * 4.0;
        }

        /// <summary>
        /// Лице на квадрат
        /// </summary>
        /// <param name="side">Страна на квадрата</param>
        /// <returns>Лице</returns>
        public static double SquareArea(double side)
        {
            return side * side;
        }

        /// <summary>
        /// Периметър на правоъгълник
        /// </summary>
        /// <param name="a">Страна на правоъгълника</param>
        /// <param name="b">Страна на правоъгълника</param>
        /// <returns>Периметър</returns>
        public static double RectanglePerimeter(double a, double b)
        {
            return 2 * (a + b);
        }

        /// <summary>
        /// Лице на правоъгълник
        /// </summary>
        /// <param name="a">Страна на правоъгълника</param>
        /// <param name="b">Страна на правоъгълника</param>
        /// <returns>Лице</returns>
        public static double RectangleArea(double a, double b)
        {
            return a * b;
        }

        /// <summary>
        /// Лице на кръг
        /// </summary>
        /// <param name="r">Радиус на кръга</param>
        /// <returns>Лице</returns>
        public static double CircleArea(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }

    }
}
