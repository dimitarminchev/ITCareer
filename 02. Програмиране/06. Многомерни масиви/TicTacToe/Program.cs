namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            bool Xwin =
            (
                  (board[0, 0] == 'X' && board[1, 1] == 'X' && board[2, 2] == 'X') ||
                  (board[0, 2] == 'X' && board[1, 1] == 'X' && board[2, 0] == 'X') ||
                  (board[0, 0] == 'X' && board[0, 1] == 'X' && board[0, 2] == 'X') ||
                  (board[1, 0] == 'X' && board[1, 1] == 'X' && board[1, 2] == 'X') ||
                  (board[2, 0] == 'X' && board[2, 1] == 'X' && board[2, 2] == 'X') ||
                  (board[0, 0] == 'X' && board[1, 0] == 'X' && board[2, 0] == 'X') ||
                  (board[0, 1] == 'X' && board[1, 1] == 'X' && board[2, 1] == 'X') ||
                  (board[0, 2] == 'X' && board[1, 2] == 'X' && board[2, 2] == 'X')
                  ? true : false
            );
            bool Owin =
            (
                  (board[0, 0] == 'O' && board[1, 1] == 'O' && board[2, 2] == 'O') ||
                  (board[0, 2] == 'O' && board[1, 1] == 'O' && board[2, 0] == 'O') ||
                  (board[0, 0] == 'O' && board[0, 1] == 'O' && board[0, 2] == 'O') ||
                  (board[1, 0] == 'O' && board[1, 1] == 'O' && board[1, 2] == 'O') ||
                  (board[2, 0] == 'O' && board[2, 1] == 'O' && board[2, 2] == 'O') ||
                  (board[0, 0] == 'O' && board[1, 0] == 'O' && board[2, 0] == 'O') ||
                  (board[0, 1] == 'O' && board[1, 1] == 'O' && board[2, 1] == 'O') ||
                  (board[0, 2] == 'O' && board[1, 2] == 'O' && board[2, 2] == 'O')
                  ? true : false
            );

            if (Xwin)
            {
                Console.WriteLine("The winner is: X");
            }
            else if (Owin)
            {
                Console.WriteLine("The winner is: O");
            }
            else
            {
                Console.WriteLine("There is no winner");
            }
        }
    }
}