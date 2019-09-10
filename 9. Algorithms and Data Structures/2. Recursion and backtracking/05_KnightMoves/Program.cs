using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_KnightMoves
{
    class Program
    {
        const int n = 5;
        static bool[,] board;
        static List<Tuple<int, int>> moves = new List<Tuple<int, int>>();        
        static Tuple<int, int> position = new Tuple<int, int>(0, 0);       

        static bool TryMove(int k)
        {
            bool result = false;
            List<Tuple<int, int>> availableMoves = GetMoves();
            for (int i = 0; i < availableMoves.Count; i++)
            {
                position = new Tuple<int, int>(availableMoves[i].Item1, availableMoves[i].Item2);
                board[position.Item1, position.Item2] = true;
                moves.Add(position);
                if (k == n * n) return true;
                result = TryMove(k + 1);
                if (result == false)
                {
                    board[availableMoves[i].Item1, availableMoves[i].Item2] = false;

                    moves.Remove(moves.Last());
                    position = moves.Last();
                }
                else break;
            }
            return result;
        }

        static List<Tuple<int, int>> GetMoves()
        {
            List<Tuple<int, int>> availableMoves = new List<Tuple<int, int>>();
            AddMove(availableMoves, -2, 1);
            AddMove(availableMoves, -2, -1);
            AddMove(availableMoves, 2, 1);
            AddMove(availableMoves, 2, -1);
            AddMove(availableMoves, 1, 2);
            AddMove(availableMoves, -1, 2);
            AddMove(availableMoves, 1, -2);
            AddMove(availableMoves, -1, -2);
            return availableMoves;
        }

        static void AddMove(List<Tuple<int, int>> availableMoves, int x, int y)
        {
            if (position.Item1 + x < n && position.Item2 + y < n && position.Item1 + x >= 0 && position.Item2 + y >= 0)
            {
                if (board[position.Item1 + x, position.Item2 + y] == false)
                {
                    availableMoves.Add(new Tuple<int, int>(position.Item1 + x, position.Item2 + y));
                }
            }
        }
        static void Main(string[] args)
        {
            moves.Add(position);
            board = new bool[n, n];
            board[0, 0] = true;
            TryMove(2);
            if (moves.Count == 1)
            {
                Console.WriteLine("No solution found");
                return;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0}\t", moves.IndexOf(moves.Where(x => x.Item1 == i && x.Item2 == j).FirstOrDefault()) + 1);
                }
                Console.WriteLine();
            }
        }
    }
}
