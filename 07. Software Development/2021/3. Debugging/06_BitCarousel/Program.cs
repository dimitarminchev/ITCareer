namespace _06_BitCarousel
{
    class Program
    {
        static void Main()
        {
            byte number = byte.Parse(System.Console.ReadLine());
            byte rotations = byte.Parse(System.Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
/* Input:
45
3
left
right
left
*/
                string direction = System.Console.ReadLine();
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
            }

            Console.WriteLine(number);
        }
    }
}
