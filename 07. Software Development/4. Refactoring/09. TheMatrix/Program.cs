using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.TheMatrix
{
    class Program
    {

        private static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive number ");
            string input = Console.ReadLine();
            int number;
            while (!int.TryParse(input, out number) || number < 1 || number > 100)
            {
                Console.WriteLine("Your number needs to be in range [1...100]");
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
                    // prekusvame ako sme se zadunili
                    break;
                }
                
                // Must be used!
                // bool outOfBoundaries =
                //    row + directionX >= number ||  // out from right side
                //    row + directionX < 0 ||        // out from left side
                //    col + directionY >= number ||  // out from top side
                //    col + directionY < 0 ||        // out from bottom side
                //    matrix[row + directionX, col + directionY] != 0;

                while (row + directionX >= number || 
                    row + directionX < 0 || 
                    col + directionY >= number || 
                    col + directionY < 0 || 
                    matrix[row + directionX, col + directionY] != 0)
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
