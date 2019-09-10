using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_KnightMoves
{
    class Program
    {
        // vars
        private const int n = 5;
        static int startx = 0, starty = 0;
        static int[,] table =
        {
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
        };
        static private Stack<int[,]> moves = new Stack<int[,]>();

        // Print Table
        static void PrintTable(int[,] matrix)
        {
            for (int x = 0; x < n; x++)
            {
                for (int y = 0; y < n; y++)
                {
                    if (matrix[x, y] < 10) Console.Write(" ");
                    Console.Write("{0}\t", matrix[x, y]);
                }
                Console.WriteLine();
            }
        }

        // Last Counter
        static int LastCounter()
        {
            var last = moves.Last();
            int max = last[0, 0];
            for (int x = 0; x < n; x++)
            {
                for (int y = 0; y < n; y++)
                {
                    if (last[x, y] > max) max = last[x, y];
                }
            }
            return max;
        }

        // Next Moves
        static private void NextMoves(int[,] table, int startx, int starty)
        {
            // All possible moves of a knight 
            // int[] X = { 2, 1, -1, -2, -2, -1,  1,  2 };
            // int[] Y = { 1, 2,  2,  1, -1, -2, -2, -1 };
            int[] X = { -2, -2, -1, -1, 2, 2, 1, 1 };
            int[] Y = { 1, -1, -2, 2, 1, -1, 2, -2 };

            // Check if each possible move is valid or not 
            for (int i = 0; i < 8; i++)
            {

                // Position of knight  after move 
                int x = startx + X[i];
                int y = starty + Y[i];

                // Valid Moves 
                if (x >= 0 && y >= 0 && x < n && y < n && table[x, y] == 0)
                {
                    var lastMove = moves.Last();
                    lastMove[x, y] = LastCounter() + 1;
                    moves.Push(lastMove);
                    NextMoves(lastMove, x, y);
                }
                // Stack Overflow: Must be Fixed
                // else moves.Pop(); 
            }
        }

        // Main Method
        static public void Main()
        {
            // First Move
            var firstMove = new int[n, n];
            firstMove[0, 0] = 1;
            moves.Push(firstMove);

            // Calculate Next Moves
            NextMoves(table, startx, starty);

            // Print Final Moves
            var finalMove = moves.Last();
            PrintTable(finalMove);
        }
    }
}
