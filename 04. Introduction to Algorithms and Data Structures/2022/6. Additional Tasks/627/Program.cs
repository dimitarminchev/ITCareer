using System;

namespace _627
{
    public class Program
    {
        // Входни данни
        static int height = int.Parse(Console.ReadLine());
        static int width = int.Parse(Console.ReadLine());
        static string[] lab = new string[height];

        // Други променливи
        static List<char> path = new List<char>(); // U=Up, D=Down, L=Left, R=Right

        /// <summary>
        /// Прочитане на входните данни за лабиринта
        /// </summary>
        static void ReadLab()
        {
            for (int i = 0; i < height; i++)
            {
                lab[i] = Console.ReadLine();
            }
        }

        /// <summary>
        /// Намиране на питищата в лабиринта
        /// </summary>
        static void FindPaths(int row, int col, char direction)
        {
            if (!IsInBounds(row, col)) return; // Еьит

            path.Add(direction);

            if (IsExit(row, col))
            {
                Console.WriteLine(string.Join("",path));
            }
            else if (!IsVisited(row, col) && IsFree(row, col, direction))
            {
                Mark(row, col);
                FindPaths(row, col + 1, 'R');
                FindPaths(row + 1, col, 'D');
                FindPaths(row, col - 1, 'L');
                FindPaths(row - 1, col, 'U');
                Unmark(row, col);
            }

            path.RemoveAt(path.Count - 1);
        }

        /// <summary>
        /// Проверка дали посочета клетка е свободна
        /// </summary>
        static bool IsFree(int row, int col, char direction)
        {
            switch (direction)
            {
                case 'D': // Down
                    {
                        if
                        (
                            row < width - 1 &&
                            col > 0 &&
                            col < height - 1 &&
                            lab[row][col + 1] == '*' &&
                            lab[row][col - 1] == '*' &&
                            lab[row + 1][col] == '*'
                        ) return false;
                        else return true;
                        break;
                    }

                case 'R': // Right
                    {
                        if
                        (
                            row < width - 1 &&
                            row > 0 &&
                            col < height - 1 &&
                            lab[row][col + 1] == '*' &&
                            lab[row - 1][col] == '*' &&
                            lab[row + 1][col] == '*'
                        ) return false;
                        else return true;
                        break;
                    }

                case 'L': // Left
                    {
                        if
                        (
                            row < width - 1 &&
                            col > 0 &&
                            row > 0 &&
                            lab[row - 1][col] == '*' &&
                            lab[row][col - 1] == '*' &&
                            lab[row + 1][col] == '*'
                        ) return false;
                        else return true;
                        break;
                    }

                case 'U': // Up
                    {
                        if
                        (
                            col > 0 &&
                            row > 0 &&
                            col < height - 1 &&
                            lab[row][col+1] == '*' &&
                            lab[row][col - 1] == '*' &&
                            lab[row - 1][col] == '*'
                        ) return false;
                        else return true;
                        break;
                    }
            }
            return true; // this not suposed to be here!
        }

        /// <summary>
        /// Дали клетката е в границите на лабиринта?
        /// </summary>
        static bool IsInBounds(int row, int col)
        {
            if (row < 0 || col >= width || col < 0 || row >= height) return false;
            else return true;
        }

        /// <summary>
        /// Дали клетката е посетена?
        /// </summary>
        static bool IsVisited(int row, int col)
        {
            if (lab[row][col] == '*') return true;
            else return false;
        }

        /// <summary>
        /// Дали това е изхода от лабиринта?
        /// </summary>
        static bool IsExit(int row, int col)
        {
            if (lab[row][col] == 'e') return true;
            else return false;
        }

        /// <summary>
        /// Маркиране на клетка като посетена
        /// </summary>
        static void Mark(int row, int col)
        {
            var copy = lab[row].ToCharArray();
            if (lab[row][col] != 'e') copy[col] = '*';
            lab[row] = string.Join("", copy);
        }

        /// <summary>
        /// Демаркиране на клетка като непосетена
        /// </summary>
        static void Unmark(int row, int col)
        {
            var copy = lab[row].ToCharArray();
            if (lab[row][col] != 'e') copy[col] = '-';
            lab[row] = string.Join("", copy);
        }

        /// <summary>
        /// Главен метод
        /// </summary>
        public static void Main(string[] args)
        {
            ReadLab();
            FindPaths(0, 0, 'S');
        }
    }
}