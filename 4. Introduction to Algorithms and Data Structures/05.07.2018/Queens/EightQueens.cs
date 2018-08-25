using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queens
{
    class EightQueens
    {
        static int solutionFound = 0;
        const int Size = 8;
        static bool[,] scoreboard = new bool[Size, Size];

        // Атакувани позиции
        static HashSet<int> attackedRows = new HashSet<int>();
        static HashSet<int> attackedColumns = new HashSet<int>();
        static HashSet<int> attackedLeftDiagonals = new HashSet<int>();
        static HashSet<int> attackedRightDiagonals= new HashSet<int>();

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

        // Може ли да поставим царица?
        static bool CanPlaceQueen(int row, int col)
        {
            var occupied = attackedRows.Contains(row) ||
                           attackedColumns.Contains(col) ||
                           attackedLeftDiagonals.Contains(col - row) ||
                           attackedRightDiagonals.Contains(row + col);
            return !occupied;
        }

        // Маркиране на полета, които царицата атакува
        static void MarkAllAttackedPositions(int row, int col)
        {
            attackedRows.Add(row); // Ред 
            attackedColumns.Add(col); // Колона
            attackedLeftDiagonals.Add(col - row); // Ляв диагонал
            attackedRightDiagonals.Add(row + col); // Десн диагонал
            scoreboard[row, col] = true;
        }

        // Демаркиране на полета, които царицата атакува
        static void UnarkAllAttackedPositions(int row, int col)
        {
            attackedRows.Remove(row); // Ред 
            attackedColumns.Remove(col); // Колона
            attackedLeftDiagonals.Remove(col - row); // Ляв диагонал
            attackedRightDiagonals.Remove(row + col); // Десн диагонал
            scoreboard[row, col] = false;
        }

        // Отпечатване на решението
        static void PrintSolution()
        {
            for (int row = 0; row < Size; row++)
            {
                for (int col = 0; col < Size; col++)
                {
                    if (scoreboard[row, col]) Console.Write('*');
                    else Console.Write('-');
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            solutionFound++;
        }
    }
}
