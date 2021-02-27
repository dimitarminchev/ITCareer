using System;

namespace WalkinInMatrix
{
    /// <summary>
    /// Walkin in matrix class.
    /// </summary>
    public class Matrix
    {
        int[,] matrix;
        int value = 1;
        int x = 0, y = 0;
        int xDirection = 1, yDirection = 1;
        int dimensions;

        int[] xDirectionInstructions = new int[] { 1, 1, 1, 0, -1, -1, -1, 0 };
        int[] yDirectionInstructions = new int[] { 1, 0, -1, -1, -1, 0, 1, 1 };

        /// <summary>
        /// Walkin in matrix class constructor.
        /// </summary>
        /// <param name="n">Integer</param>
        public Matrix(int n)
        {
            matrix = new int[n, n];
            dimensions = n;
        }

        /// <summary>
        /// Walkin in matrix class change direction method.
        /// </summary>
        private void ChangeDirection()
        {
            int currentDirectionIndex = 0;
            for (int directionIndex = 0; directionIndex < 8; directionIndex++)
            {
                if (xDirectionInstructions[directionIndex] == xDirection &&
                    yDirectionInstructions[directionIndex] == yDirection)
                {
                    currentDirectionIndex = directionIndex;
                    break;
                }
            }
            if (currentDirectionIndex == 7)
            {
                xDirection = xDirectionInstructions[0];
                yDirection = yDirectionInstructions[0];
                return;
            }
            xDirection = xDirectionInstructions[currentDirectionIndex + 1];
            yDirection = yDirectionInstructions[currentDirectionIndex + 1];
        }

        /// <summary>
        /// Walkin in matrix class has visited all method.
        /// </summary>
        /// <returns>Boolean: true or false</returns>
        private bool HasVisitedAll()
        {
            for (int x = 0; x < dimensions; x++)
            {
                for (int y = 0; y < dimensions; y++)
                {
                    if (matrix[x, y] == 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// Walkin in matrix class get unvisited cell coordinates method.
        /// </summary>
        private void GetUnvisitedCellCoords()
        {
            x = 0;
            y = 0;
            for (int i = 0; i < dimensions; i++)
            {
                for (int j = 0; j < dimensions; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        x = i;
                        y = j;
                        xDirection = 1;
                        yDirection = 1;
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// Walkin in matrix class posible move around method.
        /// </summary>
        /// <returns>Boolean: true or false</returns>
        private bool PossibleMoveAround()
        {
            int[] xDirectionInstuctions = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] yDirectionInstructions = { 1, 0, -1, -1, -1, 0, 1, 1 };
            for (int i = 0; i < 8; i++)
            {
                if (x + xDirectionInstuctions[i] >= dimensions || x + xDirectionInstuctions[i] < 0)
                {
                    xDirectionInstuctions[i] = 0;
                }

                if (y + yDirectionInstructions[i] >= dimensions || y + yDirectionInstructions[i] < 0)
                {
                    yDirectionInstructions[i] = 0;
                }
            }

            for (int i = 0; i < 8; i++)
            {
                if (matrix[x + xDirectionInstuctions[i], y + yDirectionInstructions[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Walkin in matrix class print matrix method.
        /// </summary>
        public void PrintMatrix()
        {
            for (int x = 0; x < dimensions; x++)
            {
                for (int y = 0; y < dimensions; y++)
                {
                    Console.Write("{0,3}", matrix[x, y]);
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Walkin in matrix class get around method.
        /// </summary>
        public void GetAround()
        {
            while (!HasVisitedAll())
            {
                matrix[x, y] = value;
                if (PossibleMoveAround())
                {
                    while ((x + xDirection >= dimensions || x + xDirection < 0 ||
                        y + yDirection >= dimensions || y + yDirection < 0 ||
                        matrix[x + xDirection, y + yDirection] != 0))
                    {
                        ChangeDirection();
                    }

                    x += xDirection;
                    y += yDirection;
                }
                else
                {
                    GetUnvisitedCellCoords();
                }

                value++;
            }
        }
    }
}
