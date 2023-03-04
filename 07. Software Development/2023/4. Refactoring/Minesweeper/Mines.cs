using System.Linq;

/// <summary>
/// Refactoring Task "Minesweeper" namespace.
/// </summary>
namespace Minesweeper
{
    /// <summary>
    /// Refactoring Task "Minesweeper" class "Mines".
    /// </summary>
    public static class Mines
    {
        /// <summary>
        /// Print Players Ratings
        /// </summary>
        /// <param name="points">List of ratings points</param>
        public static void Ratings(List<Ratings> points)
        {
            Console.WriteLine("\nPlayers Ratings:");
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
        /// Next move in the game
        /// </summary>
        /// <param name="board">Game board</param>
        /// <param name="bombs">Bombs board</param>
        /// <param name="row">Row position</param>
        /// <param name="col">Col position</param>
        public static void NextMove(char[,] board, char[,] bombs, int row, int col)
        {
            char getBombs = GetBombs(bombs, row, col);
            bombs[row, col] = getBombs;
            board[row, col] = getBombs;
        }

        /// <summary>
        /// Print the game board
        /// </summary>
        /// <param name="board">The game board</param>
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
        /// Create game board
        /// </summary>
        /// <returns>Game board</returns>
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
        /// Put bombs on game board
        /// </summary>
        /// <returns>Game board</returns>
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
        /// Get surrounding bombs count at desired position
        /// </summary>
        /// <param name="board">game board</param>
        /// <param name="row">Desired position row</param>
        /// <param name="col">Desired position col</param>
        /// <returns>Surrounding bombs count</returns>
        public static char GetBombs(char[,] board, int row, int col)
        {
            int count = 0;
            int boardRows = board.GetLength(0);
            int boardCols = board.GetLength(1);

            if (row - 1 >= 0)
            {
                if (board[row - 1, col] == '*')
                {
                    count++;
                }
            }

            if (row + 1 < boardRows)
            {
                if (board[row + 1, col] == '*')
                {
                    count++;
                }
            }

            if (col - 1 >= 0)
            {
                if (board[row, col - 1] == '*')
                {
                    count++;
                }
            }

            if (col + 1 < boardCols)
            {
                if (board[row, col + 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (board[row - 1, col - 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < boardCols))
            {
                if (board[row - 1, col + 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < boardRows) && (col - 1 >= 0))
            {
                if (board[row + 1, col - 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < boardRows) && (col + 1 < boardCols))
            {
                if (board[row + 1, col + 1] == '*')
                {
                    count++;
                }
            }

            return char.Parse(count.ToString());
        }
    }
}
