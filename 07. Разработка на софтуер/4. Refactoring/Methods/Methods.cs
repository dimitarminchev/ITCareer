using System;

/// <summary>
/// Refactoring task "Methods" namespace.
/// </summary>
namespace Methods
{
    /// <summary>
    /// Refactoring task "Methods" class Methods.
    /// </summary>
    public static class Methods
    {
        /// <summary>
        /// Calculate Triangle Area method.
        /// </summary>
        /// <param name="a">side a of the triangle</param>
        /// <param name="b">side b of the triangle</param>
        /// <param name="c">side c of the triangle</param>
        /// <returns>Area of the traingle</returns>
        /// <exception cref="ArgumentOutOfRangeException">In case that sides not form triangle.</exception>
        /// <exception cref="ArgumentException">In case of negative values for sides.</exception>
        public static double CalculateTriangleArea(double a, double b, double c)
        {
            if (a + b < c || a + c < b || b + c < a)
            {
                throw new ArgumentOutOfRangeException("This is not triangle.");
            }

            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides should be positive.");
            }

            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }

        /// <summary>
        /// Convert Number To Digit method
        /// </summary>
        /// <param name="number">Number</param>
        /// <returns>Digit</returns>
        /// <exception cref="IndexOutOfRangeException">In case of number is not in range [0..9]</exception>
        public static string NumberToDigit(int number)
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
                default: throw new ArgumentException("Invalid number!");
            }
        }

        /// <summary>
        /// Find max element in array.
        /// </summary>
        /// <param name="elements">Array of integer elements.</param>
        /// <returns>Max element</returns>
        /// <exception cref="ArgumentException">No elements to find max</exception>
        public static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("No elements to find max.");
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
        /// Print Object as Number method.
        /// </summary>
        /// <param name="number">Object</param>
        /// <param name="format">Format: f, %, r</param>
        /// <exception cref="ArgumentNullException">If number is null.</exception>
        /// <exception cref="ArgumentException">Format is not one of [f, %, r]</exception>
        public static void PrintAsNumber(object number, string format)
        {
            if (number == null)
            {
                throw new ArgumentNullException("Number can not be null");
            }
            if (format != "f" && format != "%" && format != "r")
            {
                throw new ArgumentException("Allowed formats are: f, %, r");
            }

            if (format == "f")
            {
                Console.WriteLine("{0:f2}", number);
            }
            else if (format == "%")
            {
                Console.WriteLine("{0:p0}", number);
            }
            else if (format == "r")
            {
                Console.WriteLine("{0,8}", number);
            }
        }

        /// <summary>
        /// Calculate Distance between two point A and B in Euclidian Coordinate system.
        /// </summary>
        /// <param name="x1">Ax</param>
        /// <param name="y1">Ay</param>
        /// <param name="x2">Bx</param>
        /// <param name="y2">By</param>
        /// <param name="isHorizontal">true if it is horisontal line, false otherwise</param>
        /// <param name="isVertical">true if it is vertical line, false otherwise</param>
        /// <returns>Distance between two point</returns>
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
