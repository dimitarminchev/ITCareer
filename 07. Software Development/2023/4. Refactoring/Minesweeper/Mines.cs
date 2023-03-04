using System.Linq;

namespace Minesweeper
{
    public static class Mines
    {
        /// <summary>
        /// Класация
        /// </summary>
        public static void Ratings(List<Ratings> points)
        {
            Console.WriteLine("\nPoints:");
            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} -> {2} boxes", i + 1, points[i].Name, points[i].Points);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty Ratings!\n");
            }
        }

        /// <summary>
        /// Ти си на ход
        /// </summary>
        public static void YourMove(char[,] board, char[,] bombs, int row, int col)
        {
            char getBombs = GetBombs(bombs, row, col);
            bombs[row, col] = getBombs;
            board[row, col] = getBombs;
        }

        /// <summary>
        /// Отпечатване на игралното поле
        /// </summary>
        public static void Print(char[,] board)
        {
            int boardRows = board.GetLength(0);
            int boardCols = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < boardRows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < boardCols; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        /// <summary>
        /// Създаване на игралното поле
        /// </summary>
        public static char[,] CreateBoard()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        /// <summary>
        /// Поставяне на бомби в игралното поле
        /// </summary>
        /// <returns></returns>
        public static char[,] PutBombs()
        {
            int boardRows = 5;
            int boardCols = 10;
            char[,] board = new char[boardRows, boardCols];

            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardCols; j++)
                {
                    board[i, j] = '-';
                }
            }

            List<int> r3 = new List<int>();
            while (r3.Count < 15)
            {
                Random random = new Random();
                int nextRandom = random.Next(50);
                if (!r3.Contains(nextRandom))
                {
                    r3.Add(nextRandom);
                }
            }

            foreach (int i2 in r3)
            {
                int col = i2 / boardCols;
                int row = i2 % boardCols;
                if (row == 0 && i2 != 0)
                {
                    col--;
                    row = boardCols;
                }
                else
                {
                    row++;
                }

                board[col, row - 1] = '*';
            }

            return board;
        }

        /// <summary>
        /// Колко бомби
        /// </summary>
        public static char GetBombs(char[,] board, int rows, int cols)
        {
            int count = 0;
            int boardRows = board.GetLength(0);
            int boardCols = board.GetLength(1);

            if (rows - 1 >= 0)
            {
                if (board[rows - 1, cols] == '*')
                {
                    count++;
                }
            }

            if (rows + 1 < boardRows)
            {
                if (board[rows + 1, cols] == '*')
                {
                    count++;
                }
            }

            if (cols - 1 >= 0)
            {
                if (board[rows, cols - 1] == '*')
                {
                    count++;
                }
            }

            if (cols + 1 < boardCols)
            {
                if (board[rows, cols + 1] == '*')
                {
                    count++;
                }
            }

            if ((rows - 1 >= 0) && (cols - 1 >= 0))
            {
                if (board[rows - 1, cols - 1] == '*')
                {
                    count++;
                }
            }

            if ((rows - 1 >= 0) && (cols + 1 < boardCols))
            {
                if (board[rows - 1, cols + 1] == '*')
                {
                    count++;
                }
            }

            if ((rows + 1 < boardRows) && (cols - 1 >= 0))
            {
                if (board[rows + 1, cols - 1] == '*')
                {
                    count++;
                }
            }

            if ((rows + 1 < boardRows) && (cols + 1 < boardCols))
            {
                if (board[rows + 1, cols + 1] == '*')
                {
                    count++;
                }
            }

            return char.Parse(count.ToString());
        }
    }
}
