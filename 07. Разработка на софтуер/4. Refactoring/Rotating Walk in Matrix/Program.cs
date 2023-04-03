/// <summary>
/// Refactoring Task "Rotating Walk in Matrix" namespace.
/// </summary>
namespace Rotating_Walk_in_Matrix
{
    /// <summary>
    /// Refactoring Task "Rotating Walk in Matrix" main program class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Refactoring Task "Rotating Walk in Matrix" main program method.
        /// </summary>
        /// <example>
        /// Input:
        /// 6
        /// 
        /// Output: 
        /// 1 16 17 18 19 20
        /// 15 2 27 28 29 21
        /// 14 31 3 26 30 22
        /// 13 36 32 4 25 23
        /// 12 35 34 33 5 24
        /// 11 10 9 8 7 6
        /// </example>
        /// <param name="args">No arguments needed.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive number ");
            string input = Console.ReadLine();
            int number;
            while (!int.TryParse(input, out number) || number < 0 || number > 100)
            {
                Console.WriteLine("You haven't entered a correct positive number");
                input = Console.ReadLine();
            }

            int[,] matrix = new int[number, number];
            int step = number;
            int value = 1;
            int row = 0;
            int col = 0;
            int directionX = 1;
            int directionY = 1;
            while (true)
            {
                // malko e kofti tova uslovie, no break-a raboti 100% : )
                matrix[row, col] = value;

                if (!Matrix.CheckCell(matrix, row, col))
                {
                    break;
                }

                // prekusvame ako sme se zadunili
                bool outOfBoundaries =
                    row + directionX >= number ||  // out from right side
                    row + directionX < 0 ||        // out from left side
                    col + directionY >= number ||  // out from top side
                    col + directionY < 0 ||        // out from bottom side
                    matrix[row + directionX, col + directionY] != 0;

                while (row + directionX >= number || row + directionX < 0 || col + directionY >= number || col + directionY < 0 || matrix[row + directionX, col + directionY] != 0)
                {
                    Matrix.Change(ref directionX, ref directionY);
                }

                row += directionX;
                col += directionY;
                value++;
            }

            Matrix.FindCell(matrix, out row, out col);
            if (row != 0 && col != 0)
            {
                // taka go napravih, zashtoto funkciqta ne mi davashe da ne si definiram out parametrite
                directionX = 1;
                directionY = 1;

                while (true)
                {
                    // malko e kofti tova uslovie, no break-a raboti 100% : )
                    matrix[row, col] = value;
                    if (!Matrix.CheckCell(matrix, row, col))
                    {
                        break;
                    }
                    // prekusvame ako sme se zadunili
                    if (row + directionX >= number || row + directionX < 0 || col + directionY >= number || col + directionY < 0 || matrix[row + directionX, col + directionY] != 0)
                    {
                        while (row + directionX >= number || row + directionX < 0 || col + directionY >= number || col + directionY < 0 || matrix[row + directionX, col + directionY] != 0)
                        {
                            Matrix.Change(ref directionX, ref directionY);
                        }
                    }

                    row += directionX;
                    col += directionY;
                    value++;
                }
            }

            for (int pp = 0; pp < number; pp++)
            {
                for (int qq = 0; qq < number; qq++)
                {
                    Console.Write("{0,3}", matrix[pp, qq]);
                }

                Console.WriteLine();
            }
        }
    }
}