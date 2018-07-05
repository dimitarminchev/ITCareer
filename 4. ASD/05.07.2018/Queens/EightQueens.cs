using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queens
{
    class EightQueens
    {
        const int Size = 8;
        static bool[,] chassboard = new bool[Size, Size];

        // Атакувани позиции
        static HashSet<int> attackedRows = new HashSet<int>();
        static HashSet<int> attackedColumns = new HashSet<int>();
        static HashSet<int> attackedLeftDiagonals = new HashSet<int>();
        static HashSet<int> attackedRightDiagonals= new HashSet<int>();

        // leftDiag = col - row
        // rightDiag = col + row

        // BackTraking Algorithm
        public static void PutQueens(int row)
        {
            if (row == Size) PrintSolution(); // изход
            else
            {
                for (int col = 0; col < Size; col++)
                {
                    if (CanPlaceQueen(row, col))
                    {
                        MarkAllAttackedPositions(row, col); // прав ход
                        PutQueens(row + 1); // рекурсия
                        UnarkAllAttackedPositions(row, col); // обратен ход
                    }
                }
            }
        }

        // може ли да поставим царица
        static bool CanPlaceQueen(int row, int col)
        {
            var occupied = attackedRows.Contains(row) ||
                           attackedColumns.Contains(col) ||
                           attackedLeftDiagonals.Contains(col - row) ||
                           attackedRightDiagonals.Contains(row + col);
            return !occupied;
        }
    }
}
