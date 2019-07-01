using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            const int rows = 3, cols = 3;
            char[,] board = new char[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                var line = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    board[row, col] = line[col];
                }
            }

            // Winning Check!
            bool Xwin =
            (
                  (board[0, 0] == 'X' && board[1, 1] == 'X' && board[2, 2] == 'X') || // d1
                  (board[0, 2] == 'X' && board[1, 1] == 'X' && board[2, 0] == 'X') || // d2
                  (board[0, 0] == 'X' && board[0, 1] == 'X' && board[0, 2] == 'X') || // r1
                  (board[1, 0] == 'X' && board[1, 1] == 'X' && board[1, 2] == 'X') || // r2
                  (board[2, 0] == 'X' && board[2, 1] == 'X' && board[2, 2] == 'X') || // r3
                  (board[0, 0] == 'X' && board[1, 0] == 'X' && board[2, 0] == 'X') || // c1
                  (board[0, 1] == 'X' && board[1, 1] == 'X' && board[2, 1] == 'X') || // c2
                  (board[0, 2] == 'X' && board[1, 2] == 'X' && board[2, 2] == 'X')    // c3
                  ? true : false
            );
            bool Owin =
            (
                  (board[0, 0] == 'O' && board[1, 1] == 'O' && board[2, 2] == 'O') || // d1
                  (board[0, 2] == 'O' && board[1, 1] == 'O' && board[2, 0] == 'O') || // d2
                  (board[0, 0] == 'O' && board[0, 1] == 'O' && board[0, 2] == 'O') || // r1
                  (board[1, 0] == 'O' && board[1, 1] == 'O' && board[1, 2] == 'O') || // r2
                  (board[2, 0] == 'O' && board[2, 1] == 'O' && board[2, 2] == 'O') || // r3
                  (board[0, 0] == 'O' && board[1, 0] == 'O' && board[2, 0] == 'O') || // c1
                  (board[0, 1] == 'O' && board[1, 1] == 'O' && board[2, 1] == 'O') || // c2
                  (board[0, 2] == 'O' && board[1, 2] == 'O' && board[2, 2] == 'O')    // c3
                  ? true : false
            );

            if (Xwin) Console.WriteLine("The winner is: X");
            else if (Owin) Console.WriteLine("The winner is: O");
            else Console.WriteLine("There is no winner");

        }
    }
}
