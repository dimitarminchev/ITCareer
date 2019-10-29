using System;

namespace Methods
{
    public class Methods
    {
        static public double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides should be positive!");
                // Console.Error.WriteLine("Sides should be positive.");
                // return -1;
            }
            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }

        static public string NumberToDigit(int number)
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
            // return "Invalid number!";
        }

        static public int FindMaxElementInArray(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                // return -1;
                throw new ArgumentNullException("Array does not contain elements.");
            }

            int max = elements[0];
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > max)
                {
                    max = elements[i];
                }
            }
            return max;
        }

        static public void PrintAsNumber(object number, char format)
        {
            switch (format)
            {
                case 'f':
                    {
                        Console.WriteLine("{0:f2}", number);
                        break;
                    }
                case '%':
                    {
                        Console.WriteLine("{0:p0}", number);
                        break;
                    }
                case 'r':
                    {
                        Console.WriteLine("{0,8}", number);
                        break;
                    }
                default:
                    throw new ArgumentException("Format is not valid");
            }
        }

        static public double CalcDistance(double x1, double y1, double x2, double y2,
        out bool isHorizontal, out bool isVertical)
        {
            isHorizontal = (y1 == y2);
            isVertical = (x1 == x2);

            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }
    } 
}

