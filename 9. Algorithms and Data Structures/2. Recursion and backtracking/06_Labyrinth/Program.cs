using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Labyrinth
{
    class Program
    {
        static int n, m;
        static bool[,] canVisit;
        static Position exit;
        static string currentSolution = string.Empty;
        static List<string> allSolutions = new List<string>();

        static void FindLabyrinthSolutions(Position currentPosition)
        {
            if (currentPosition == exit)
            {
                allSolutions.Add(currentSolution);
                return;
            }
            else if (!PositionIsOK(currentPosition))
            {
                return;
            }
            else
            {
                canVisit[currentPosition.X, currentPosition.Y] = false;

                Position nextPosition = new Position(currentPosition.X, currentPosition.Y);

                nextPosition.X += 1;
                currentSolution += "D";
                FindLabyrinthSolutions(nextPosition);
                currentSolution = currentSolution.Remove(currentSolution.Length - 1);

                nextPosition.X -= 2;
                currentSolution += "U";
                FindLabyrinthSolutions(nextPosition);
                currentSolution = currentSolution.Remove(currentSolution.Length - 1);

                nextPosition.X += 1;
                nextPosition.Y += 1;
                currentSolution += "R";
                FindLabyrinthSolutions(nextPosition);
                currentSolution = currentSolution.Remove(currentSolution.Length - 1);

                nextPosition.Y -= 2;
                currentSolution += "L";
                FindLabyrinthSolutions(nextPosition);
                currentSolution = currentSolution.Remove(currentSolution.Length - 1);

                canVisit[currentPosition.X, currentPosition.Y] = true;
            }
        }

        static bool PositionIsOK(Position position)
        {
            if (position.X < 0 || position.X >= n)
            {
                return false;
            }
            if (position.Y < 0 || position.Y >= m)
            {
                return false;
            }
            return canVisit[position.X, position.Y];
        }

        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            n = dimensions[0];
            m = dimensions[1];
            canVisit = new bool[n, m];

            for (int i = 0; i < n; i++)
            {
                string inputLine = Console.ReadLine();
                int colIndex = 0;
                foreach (var ch in inputLine)
                {
                    canVisit[i, colIndex] = true;
                    if (ch == '*')
                        canVisit[i, colIndex] = false;
                    else if (ch == 'e')
                        exit = new Position(i, colIndex);
                    colIndex++;
                }
            }

            Position startingPosition = new Position(0, 0);
            FindLabyrinthSolutions(startingPosition);

            allSolutions.ForEach(x => Console.WriteLine(x));
        }
    }
}
