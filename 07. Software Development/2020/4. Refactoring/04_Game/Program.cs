using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game
{
    public class Program
    {

        private static void Main(string[] args)
        {
            string command = string.Empty;
            char[,] playground = Minesweeper.CreatePlayground();
            char[,] bombs = Minesweeper.SetBombs();
            int performedMoves = 0;
            bool isExploding = false;
            List<Ranking> participants = new List<Ranking>(6);
            int row = 0;
            int colomn = 0;
            bool isNewGame = true;
            const int maxTurns = 35;
            bool hasFinished = false;
            do
            {
                if (isNewGame)
                {
                    Console.WriteLine(
                        "Let's play Minesweeper. Try your luck to find fields without mines."
                        + Environment.NewLine +
                        "Command 'top' shows the ranking, 'restart' starts new game, 'exit' quits the game!");
                    Minesweeper.DrawPlayground(playground);
                    isNewGame = false;
                }

                Console.Write("Enter row and colomn : ");
                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                        int.TryParse(command[2].ToString(), out colomn) &&
                        row <= playground.GetLength(0) &&
                        colomn <= playground.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        Minesweeper.RankChampions(participants);
                        break;
                    case "restart":
                        playground = Minesweeper.CreatePlayground();
                        bombs = Minesweeper.SetBombs();
                        Minesweeper.DrawPlayground(playground);
                        isExploding = false;
                        isNewGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye, bye");
                        break;
                    case "turn":
                        if (bombs[row, colomn] != '*')
                        {
                            if (bombs[row, colomn] == '-')
                            {
                                Minesweeper.PerformMove(playground, bombs, row, colomn);
                                performedMoves++;
                            }

                            if (maxTurns == performedMoves)
                            {
                                hasFinished = true;
                            }
                            else
                            {
                                Minesweeper.DrawPlayground(playground);
                            }
                        }
                        else
                        {
                            isExploding = true;
                        }
                        break;
                    default:
                        Console.WriteLine("\nIncorrect command\n");
                        break;
                }

                if (isExploding)
                {
                    Minesweeper.DrawPlayground(bombs);
                    Console.Write("\nYou died with {0} points. " +
                                    Environment.NewLine +
                                    "Enter your nickname: ", performedMoves);
                    string nickname = Console.ReadLine();
                    Ranking record = new Ranking(nickname, performedMoves);
                    if (participants.Count < 5)
                    {
                        participants.Add(record);
                    }
                    else
                    {
                        for (int i = 0; i < participants.Count; i++)
                        {
                            if (participants[i].Points < record.Points)
                            {
                                participants.Insert(i, record);
                                participants.RemoveAt(participants.Count - 1);
                                break;
                            }
                        }
                    }

                    participants.Sort((Ranking player1, Ranking player2) =>
                    player2.Player.CompareTo(player1.Player));
                    participants.Sort((Ranking player1, Ranking player2) =>
                    player2.Points.CompareTo(player1.Points));
                    Minesweeper.RankChampions(participants);
                    playground = Minesweeper.CreatePlayground();
                    bombs = Minesweeper.SetBombs();
                    performedMoves = 0;
                    isExploding = false;
                    isNewGame = true;
                }

                if (hasFinished)
                {
                    Console.WriteLine("\nGreaaat! You opened 35 fields without getting damaged!");
                    Minesweeper.DrawPlayground(bombs);
                    Console.WriteLine("Enter your name:");
                    string name = Console.ReadLine();
                    Ranking record = new Ranking(name, performedMoves);
                    participants.Add(record);
                    Minesweeper.RankChampions(participants);
                    playground = Minesweeper.CreatePlayground();
                    bombs = Minesweeper.SetBombs();
                    performedMoves = 0;
                    hasFinished = false;
                    isNewGame = true;
                }
            }
            while (command != "exit");

            Console.WriteLine("Made in Bulgaria");
            Console.Read();
        }
    
    }
}