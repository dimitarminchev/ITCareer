namespace BitCarousel
{

    public class BitCarousel
    {
        static void Main()
        {
            byte number = byte.Parse(System.Console.ReadLine()); // 45
            byte rotations = byte.Parse(System.Console.ReadLine()); // 3 left right left

            for (int i = 0; i < rotations; i++)
            {
                string direction = System.Console.ReadLine();

                // fix: bit shifting
                if (direction == "right")
                {
                                                         // 00011011 = 27
                    int rightMostBit = number & 1;       // 00000001 = 1
                    number >>= 1;                        // 00001101 = 13
                    number |= (byte)(rightMostBit << 5); // 00101101 = 45
                }
                else if (direction == "left")
                {
                                                         // 00101101 = 45
                    int leftMostBit = (number >> 5) & 1; // 00000001 =  1
                    number <<= 1;                        // 01011010 = 90 
                    number |= (byte)leftMostBit;         // 01011011 = 91
                    number ^= (byte)(leftMostBit << 6);  // 00011011 = 27

                }
                /*
                if (direction == "right")
                {
                    int rightMostBit = number & 1;
                    number >>= 1;
                    number |= (byte)(rightMostBit << 6);
                }
                else if (direction == "left")
                {
                    int leftMostBit = (number >> 6) & 1;
                    number <<= 1;
                    number |= (byte)leftMostBit;
                }
                */
            }

            Console.WriteLine(number);
        }
    }
}
