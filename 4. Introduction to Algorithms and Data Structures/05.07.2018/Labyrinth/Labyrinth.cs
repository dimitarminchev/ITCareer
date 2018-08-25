using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinth
{
    class Labyrinth
    {
        // Лабиринт
        public static char[,] lab;

        // Намерен път в лабиринта
        public static List<char> path = new List<char>();

        // Четене на лабирината = O(N)
        public static char[,] ReadLab()
        {
                        
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            lab = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var line = Console.ReadLine();
                for (int col = 0; col < cols; col++)
                lab[row, col] = line[col];
            }

            return lab; // Lab is Ready!
        }

        // Рекурсивно намиране на пътя
        public static void FindPaths(int row, int col, char direction)
        {
            if (!IsInBound(row, col)) return;
            path.Add(direction); // add to path
            if (IsExit(row, col)) PrintPath();
            else if (!IsVisited(row, col) && IsFree(row, col))
            {
                Mark(row, col); // Visited
                FindPaths(row, col + 1, 'R'); // Right
                FindPaths(row + 1, col, 'D'); // Down
                FindPaths(row, col - 1, 'L'); // Left
                FindPaths(row - 1, col, 'U'); // Up
                Unmark(row, col); // Unvisited
            }
            path.RemoveAt(path.Count - 1); // remove drom path
        }

        // Валидиране дали сме в границите на лабиринта
        public static bool IsInBound(int row, int col)
        {
            return row >= 0 && row < lab.GetLength(0) &&
                   col >= 0 && col < lab.GetLength(1) &&
                   lab[row, col] != '*';
        }

        // Проверка дали е изход
        public static bool IsExit(int row, int col)
        {
            return lab[row, col] == 'e';
        }

        // Отпечатване на пътя
        public static void PrintPath()
        {
            var result = string.Join("", path);
            Console.WriteLine(result.Substring(1,result.Length-1));
        }

        // Дали дадена клетка е посетена
        public static bool IsVisited(int row, int col)
        {
            return lab[row,col] == 'v'; // v = visited
        }

        // Проверка дали дадена клетка
        public static bool IsFree(int row, int col)
        {
            return lab[row,col] == '-';
        }

        // Маркираме клетка като посетена
        public static void Mark(int row, int col)
        {
            lab[row, col] = 'v'; // v = visited
        }

        // Маркиртаме клетка като непосетена
        public static void Unmark(int row, int col)
        {
            lab[row, col] = '-';
        }
    }
}
