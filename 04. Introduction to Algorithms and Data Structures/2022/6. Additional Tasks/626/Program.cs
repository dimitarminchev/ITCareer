using System;

namespace _626
{
    /// <summary>
    /// Шахматната дъска
    /// </summary>
    public static class EightQueens
    {

        public const int Size = 8; // Размер на шахматната дъска
        public static bool[,] chessboard = new bool[Size, Size]; // Шахматна дъска
    }

    public class Program
    {
        static HashSet<int> attackedRows = new HashSet<int>();
        static HashSet<int> attackedColumns = new HashSet<int>();
        static HashSet<int> attackedLeftDiagonals = new HashSet<int>();
        static HashSet<int> attackedRightDiagonals = new HashSet<int>();

        /// <summary>
        /// Поставяне на царица на шахматната дъска
        /// </summary>
        static void PutQueen(int row)
        {
            if (row == EightQueens.Size)
            {
                PrintSolution();
  
            }
            else 
            {
                for (int col = 0; col < EightQueens.Size; col++)
                {
                    if (CanPlaceQueen(row, col))
                    {
                        MarkAllAttacketPositions(row, col);
                        PutQueen(row + 1);
                        UnmarkAllAttackedPositions(row, col);
                    }
                }
            }
        }

        /// <summary>
        /// Може ли да се постави царица на определени координати row и col?
        /// </summary>
        static bool CanPlaceQueen(int row, int col)
        {
            var positionOccupied =
                attackedRows.Contains(row) ||
                attackedColumns.Contains(col) ||
                attackedLeftDiagonals.Contains(col - row) ||
                attackedRightDiagonals.Contains(row + col);
            return !positionOccupied;
        }

        /// <summary>
        /// Мaркираме полетата които царицата може да атакува
        /// </summary>
        static void MarkAllAttacketPositions(int row, int col) 
        {
            attackedRows.Add(row);
            attackedColumns.Add(col);
            attackedLeftDiagonals.Add(row - col);
            attackedRightDiagonals.Add(row + col);

            EightQueens.chessboard[row, col] = true;
        }

        /// <summary>
        /// Demaркираме полетата които царицата атакува
        /// </summary>
        static void UnmarkAllAttackedPositions(int row, int col)
        {
            attackedRows.Remove(row);
            attackedColumns.Remove(col);
            attackedLeftDiagonals.Remove(row - col);
            attackedRightDiagonals.Remove(row + col);

            EightQueens.chessboard[row, col] = false;
        }

        /// <summary>
        /// Отпечатване на получено решение
        /// </summary>
        static void PrintSolution()
        {
            for (int row = 0; row < EightQueens.Size; row++)
            {
                for (int col = 0; col < EightQueens.Size; col++)
                {
                    if (EightQueens.chessboard[row, col] == true)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('-');
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Главен метод
        /// </summary>
        public static void Main(string[] args)
        {
            PutQueen(0);
        }
    }
}