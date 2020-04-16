using System;
using System.Collections.Generic;

namespace Game
{
    public static class Minesweeper
    {
        public static void RankChampions(List<Ranking> points)
        {
            Console.WriteLine("\nPoints:");
            if (points.Count <= 0)
            {
                Console.WriteLine("No ranking records!\n");
            }
            else
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} fields", i + 1,
                                      points[i].Player, points[i].Points);
                }
                Console.WriteLine();
            }
        }
        public static void PerformMove(char[,] field, char[,] bombs, int row, int colomn)
        {
            char bombsCount = CountBombs(bombs, row, colomn);
            bombs[row, colomn] = bombsCount;
            field[row, colomn] = bombsCount;
        }
        public static void DrawPlayground(char[,] board)
        {
            int rows = board.GetLength(0);
            int colomns = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < colomns; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine("   ---------------------\n");
        }
        public static char[,] CreatePlayground()
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
        public static char[,] SetBombs()
        {
            int rows = 5;
            int colomns = 10;
            char[,] playground = new char[rows, colomns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colomns; j++)
                {
                    playground[i, j] = '-';
                }
            }

            List<int> bombs = new List<int>();

            while (bombs.Count < 15)
            {
                Random random = new Random();
                int randomIndex = random.Next(50);
                if (!bombs.Contains(randomIndex))
                {
                    bombs.Add(randomIndex);
                }
            }

            foreach (int position in bombs)
            {
                int colomn = position / colomns;
                int row = position % colomns;
                if (row == 0 && position != 0)
                {
                    colomn--;
                    row = colomns;
                }
                else
                {
                    row++;
                }
                playground[colomn, row - 1] = '*';
            }
            return playground;
        }
        public static void GetBombsData(char[,] field)
        {
            int colomn = field.GetLength(0);
            int row = field.GetLength(1);
            for (int i = 0; i < colomn; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (field[i, j] != '*')
                    {
                        field[i, j] = CountBombs(field, i, j);

                    }
                }
            }
        }

        public static char CountBombs(char[,] board, int row, int colomn)
        {
            int count = 0;
            int rows = board.GetLength(0);
            int colomns = board.GetLength(1);
            if (row - 1 >= 0)
            {
                if (board[row - 1, colomn] == '*')
                {
                    count++;
                }
            }
            if (row + 1 < rows)
            {
                if (board[row + 1, colomn] == '*')
                {
                    count++;
                }
            }
            if (colomn - 1 >= 0)
            {
                if (board[row, colomn - 1] == '*')
                {
                    count++;
                }
            }
            if (colomn + 1 < colomns)
            {
                if (board[row, colomn + 1] == '*')
                {
                    count++;
                }
            }
            if ((row - 1 >= 0) && (colomn - 1 >= 0))
            {
                if (board[row - 1, colomn - 1] == '*')
                {
                    count++;
                }
            }
            if ((row - 1 >= 0) && (colomn + 1 < colomns))
            {
                if (board[row - 1, colomn + 1] == '*')
                {
                    count++;
                }
            }
            if ((row + 1 < rows) && (colomn - 1 >= 0))
            {
                if (board[row + 1, colomn - 1] == '*')
                {
                    count++;
                }
            }
            if ((row + 1 < rows) && (colomn + 1 < colomns))
            {
                if (board[row + 1, colomn + 1] == '*')
                {
                    count++;
                }
            }
            return char.Parse(count.ToString());
        }
    }
}
