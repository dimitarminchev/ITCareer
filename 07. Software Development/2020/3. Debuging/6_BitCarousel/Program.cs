using System;

/// <summary>
/// 3. Debuging, 6. Bit Carousel
/// </summary>
namespace _6_BitCarousel
{
    /// <summary>
    /// Main Program Class: 3. Debuging, 6. Bit Carousel
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Input:
        /// 42
        /// 1
        /// left
        /// Output:
        /// 21
        /// </summary>
        public static void Main()
        {
            byte number = byte.Parse(Console.ReadLine());
            byte rotations = byte.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                string direction = Console.ReadLine();

                if (direction == "right")
                {
                    int rightMostBit = number & 1;
                    number >>= 1;
                    number |= (byte)(rightMostBit << 5);
                }
                else if (direction == "left")
                {
                    int leftMostBit = (number >> 5) & 1;
                    number <<= 1;
                    number &= 63;
                    number |= (byte)leftMostBit;
                }
            }

            Console.WriteLine(number);
        }
    }
}
