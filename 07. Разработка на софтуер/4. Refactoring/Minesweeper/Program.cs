using System.Diagnostics.Metrics;

/// <summary>
/// Refactoring Task "Minesweeper" namespace.
/// </summary>
namespace Minesweeper
{
    /// <summary>
    /// Refactoring Task "Minesweeper" main program class.
    /// </summary>
    public class Program
    {
        private static List<Ratings> ratings = new List<Ratings>(6);
        private static char[,] board = Mines.CreateBoard();
        private static char[,] bombs = Mines.PutBombs();

        private static void SetGame()
        {
            board = Mines.CreateBoard();
            bombs = Mines.PutBombs();
        }

        private static void SetRating(int counter)
        {
            Console.WriteLine("Enter player name: ");
            string name = Console.ReadLine();
            Ratings t = new Ratings(name, counter);
            if (ratings.Count < 5)
            {
                ratings.Add(t);
            }
            else
            {
                for (int i = 0; i < ratings.Count; i++)
                {
                    if (ratings[i].Points < t.Points)
                    {
                        ratings.Insert(i, t);
                        ratings.RemoveAt(ratings.Count - 1);
                        break;
                    }
                }
            }

            ratings.Sort((Ratings r1, Ratings r2) => r2.Name.CompareTo(r1.Name));
            ratings.Sort((Ratings r1, Ratings r2) => r2.Points.CompareTo(r1.Points));
            Mines.Ratings(ratings);
        }

        /// <summary>
        /// Refactoring Task "Minesweeper" main program method.
        /// </summary>
        /// <example>
        /// Let's play Minesweeper! 
        /// Command 'top' shows rating, command 'restart' starts a new game, command 'exit' leaves the game!
        ///
        ///     0 1 2 3 4 5 6 7 8 9
        ///    ---------------------
        /// 0 | ? ? ? ? ? ? ? ? ? ? |
        /// 1 | ? ? ? ? ? ? ? ? ? ? |
        /// 2 | ? ? ? ? ? ? ? ? ? ? |
        /// 3 | ? ? ? ? ? ? ? ? ? ? |
        /// 4 | ? ? ? ? ? ? ? ? ? ? |
        ///    ---------------------
        ///    
        /// Enter[row, col] :
        /// </example>
        /// <param name="args">No arguments needed.</param>
        public static void Main(string[] args)
        {
            const int MAX = 35;
            string command = string.Empty;
            int row = 0;
            int col = 0;
            int counter = 0;
            bool IsNewGame = true;
            bool IsHitBomb = false;
            bool IsPlayerWin = false;

            do
            {
                if (IsNewGame)
                {
                    Console.WriteLine("Let's play Minesweeper! ");
                    Console.WriteLine("Command 'top' shows rating, command 'restart' starts a new game, command 'exit' leaves the game!");
                    Mines.Print(board);
                    IsNewGame = false;
                }

                Console.Write("Enter [row, col] : ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) && int.TryParse(command[2].ToString(), out col)
                        && row <= board.GetLength(0) && col <= board.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        Mines.Ratings(ratings);
                        break;

                    case "restart":
                        SetGame();
                        Mines.Print(board);
                        IsHitBomb = false;
                        IsNewGame = false;
                        break;

                    case "exit":
                        Console.WriteLine("4a0, 4a0, 4a0!");
                        break;

                    case "turn":
                        if (bombs[row, col] != '*')
                        {
                            if (bombs[row, col] == '-')
                            {
                                Mines.NextMove(board, bombs, row, col);
                                counter++;
                            }

                            if (MAX == counter)
                            {
                                IsPlayerWin = true;
                            }
                            else
                            {
                                Mines.Print(board);
                            }
                        }
                        else
                        {
                            IsHitBomb = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nError! Invalid Command\n");
                        break;
                }

                if (IsHitBomb)
                {
                    Console.Write("\nGame Over! Score {0} points.", counter);
                    Mines.Print(bombs);

                    SetRating(counter);
                    SetGame();

                    counter = 0;
                    IsHitBomb = false;
                    IsNewGame = true;
                }

                if (IsPlayerWin)
                {
                    Console.WriteLine("\nYou win! You found 35 bombs without loosing one.");
                    Mines.Print(bombs);

                    SetRating(counter);
                    SetGame();

                    counter = 0;
                    IsPlayerWin = false;
                    IsNewGame = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria");
            Console.Read();
        }
    }
}