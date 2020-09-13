using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Maze_Paths
{
    class Program
    {
        static int totalSolutions = 0;
        static readonly Stack<char> currentSolution = new Stack<char>();
        static readonly List<string> solutions = new List<string>();

        static void Main()
        {
/*
Input 1:
3 3
---
-*-
--e

Ouput 1:
RRDD
DDRR

Input 2:
3 5
-**-e
-----
*****

Output 2:
DRRRRU
DRRRUR
*/
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int m = input[0];
            int n = input[1];
            char[,] board = new char[m, n];
            for (int i = 0; i < m; i++)
            {
                var line = Console.ReadLine().ToCharArray();
                for (int j = 0; j < n; j++)
                {
                    board[i, j] = line[j];
                }
            }

            Solve(board, 0, 0);

            Console.WriteLine($"Total Solutions: {totalSolutions}");
        }

        private static void Solve(char[,] board, int x, int y)
        {
            if (!(x >= 0 && x < board.GetLength(0) && y >= 0 && y < board.GetLength(1)))
            {
                currentSolution.Pop();
                return;
            }

            if (board[x, y] == '*' || board[x, y] == 'x')
            {
                currentSolution.Pop();
                return;
            }

            if (board[x, y] == 'e')
            {
                PrintBoard(board);
                currentSolution.Pop();
                return;
            }

            board[x, y] = 'x';

            currentSolution.Push('R');
            Solve(board, x, y + 1);

            currentSolution.Push('D');
            Solve(board, x + 1, y);

            currentSolution.Push('L');
            Solve(board, x, y - 1);

            currentSolution.Push('U');
            Solve(board, x - 1, y);

            board[x, y] = '-';
            if (currentSolution.Any())
            {
                currentSolution.Pop();
            }
        }

        private static void PrintBoard(char[,] board)
        {
            totalSolutions++;
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write("{0,3} ", board[i, j]);
                }
                Console.WriteLine();
            }
            var solution = string.Join("", currentSolution.Reverse());
            solutions.Add(solution);
            Console.WriteLine(solution);
            Console.WriteLine();
        }
    }
}
