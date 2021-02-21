using System;

namespace Methods
{
    public static class Methods
    {
        /// <summary>
        /// Calculate Triangle Area
        /// </summary>
        /// <param name="a">Side a</param>
        /// <param name="b">Side b</param>
        /// <param name="c">Side c</param>
        /// <returns></returns>
        public static double CalculateTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides should be positive.");
            }
            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }

        /// <summary>
        /// Digit To String
        /// </summary>
        /// <param name="number">Digit</param>
        /// <returns>String</returns>
        public static string DigitToString(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default:  throw new ArgumentException("Invalid number!");
            }
        }

        /// <summary>
        /// Find Maximum Element from Integer Array
        /// </summary>
        /// <param name="elements">Integer Array</param>
        /// <returns>The maximum element</returns>
        public static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("Incorrect input");
            }

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > elements[0])
                {
                    elements[0] = elements[i];
                }
            }
            return elements[0];
        }

        /// <summary>
        /// Print Number as Formatted String
        /// </summary>
        /// <param name="number">Number</param>
        /// <param name="format">Format</param>
        public static void PrintAsNumber(object number, string format)
        {
            switch (format)
            {
                case "f": Console.WriteLine("{0:f2}", number); break;
                case "%": Console.WriteLine("{0:p0}", number); break;
                case "r": Console.WriteLine("{0,8}", number); break;
                default: throw new ArgumentException("Incorrect input");
            }
        }

        /// <summary>
        /// Calculate Euclidean Distance in 2D space
        /// </summary>
        /// <param name="x1">Point 1 Coordinate X</param>
        /// <param name="y1">Point 1 Coordinate Y</param>
        /// <param name="x2">Point 2 Coordinate X</param>
        /// <param name="y2">Point 2 Coordinate Y</param>
        /// <param name="isHorizontal">Is Horizontal Line</param>
        /// <param name="isVertical">Is Vertical Line</param>
        /// <returns></returns>
        public static double CalculateDistance(double x1, double y1, double x2, double y2, 
            out bool isHorizontal, out bool isVertical)
        {
            isHorizontal = (y1 == y2);
            isVertical = (x1 == x2);

            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

    }
}
