using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.BitCarousel
{
    class Program
    {
        static void Main()
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
                    var shiftingBit = rightMostBit << 5; // fix 1: 6 > 5
                    number |= (byte)(shiftingBit);
                }
                else if (direction == "left") 
                {
                    int leftMostBit = (number >> 5) & 1; // fix 2: 6 > 5
                    number <<= 1;
                    number &= 63; // fix 3: Remove first 2 bits
                    number |= (byte)leftMostBit;
                }
            }

            Console.WriteLine(number);
        }
    }
}
