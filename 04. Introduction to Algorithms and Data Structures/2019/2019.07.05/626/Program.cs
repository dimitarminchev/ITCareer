using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _626
{
    class Program
    {
        // 626* = Eight Queens
        static int solutionsFound = 0;
        const int Size = 8;
        static bool[,] chessboard = new bool[Size, Size];
        static HashSet<int> attackedRows = new HashSet<int>();
        static HashSet<int> attackedColumns = new HashSet<int>();
        static HashSet<int> attackedLeftDiagonals = new HashSet<int>();
        static HashSet<int> attackedRightDiagonals = new HashSet<int>();
        //leftDiag = col - row;   //-7  7
        //rightDiag = col + row;   //0  14
        public static void PutQueens(int row)
        {
            if (row == Size)
            {
                PrintSolution();
            }
            else
            {
                for (int col = 0; col < Size; col++)
                {
                    if (CanPlaceQueen(row, col))
                    {
                        MarkAllAttackedPositions(row, col);
                        PutQueens(row + 1);
                        UnmarkAllAttackedPositions(row, col);
                    }
                }
            }
        }
        static bool CanPlaceQueen(int row, int col)
        {
            var positionOccupied = attackedRows.Contains(row) || attackedColumns.Contains(col) || attackedLeftDiagonals.Contains(col - row) || attackedRightDiagonals.Contains(row + col);
            return !positionOccupied;
        }
        static void MarkAllAttackedPositions(int row, int col)
        {
            attackedRows.Add(row);
            attackedColumns.Add(col);
            attackedLeftDiagonals.Add(col - row);
            attackedRightDiagonals.Add(row + col);
            chessboard[row, col] = true;
        }
        static void UnmarkAllAttackedPositions(int row, int col)
        {
            attackedRows.Remove(row);
            attackedColumns.Remove(col);
            attackedLeftDiagonals.Remove(col - row);
            attackedRightDiagonals.Remove(row + col);
            chessboard[row, col] = false;
        }
        static void PrintSolution()
        {
            for (int row = 0; row < Size; row++)
            {
                for (int col = 0; col < Size; col++)
                {
                    if (chessboard[row, col])
                        Console.Write("* ");
                    else Console.Write("- ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            solutionsFound++;
        }

        static void Main(string[] args)
        {
            PutQueens(0);
        }
    }
}
