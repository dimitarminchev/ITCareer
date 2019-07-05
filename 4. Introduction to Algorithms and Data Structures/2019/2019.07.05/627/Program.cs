using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _627
{
    class Program
    {
        // 627* = Labyrinth
        public static void FindPath(int row,int col,char direction)
        {
            if (!IsInBounds(row, col))
                return;
            path.Add(direction);
           for (int i = 0; i < height; i++)
            {
                Console.WriteLine(lab[i]);
            }
            Console.WriteLine();
            if (IsExit(row,col))
            {
                Console.WriteLine(string.Join(" ",path));
            }
             else if (!IsVisited(row,col)&&IsFree(row,col,direction))
            {
                Mark(row, col,direction);
                FindPath(row, col + 1, 'R');
                FindPath(row+1, col , 'D');
                FindPath(row, col - 1, 'L');
                FindPath(row-1, col , 'U');
                Unmark(row, col);
            }
            path.RemoveAt(path.Count - 1);
        }
            public static void Unmark(int row, int col)
            {
                var copy = lab[row].ToCharArray();
                //if (CountedPaths(row, col, direction) <= 1)
                if (lab[row][col] != searchedSymbol)
                    copy[col] = '-';
                lab[row] = string.Join("", copy);
            }
        public static int CountedPaths(int row,int col,char direction)
        {
            int counter = 0;
            switch (direction)
            {
                case 'D':
                    {
                            if (lab[row][col + 1] == '*') counter++;
                            if (lab[row][col - 1] == '*') counter++;
                            if (lab[row + 1][col] == '*') counter++;
                        break;
                    }
                case 'R':
                    {
                            if (lab[row][col + 1] == '*') counter++;
                            if (lab[row + 1][col] == '*') counter++;
                            if (lab[row + -1][col] == '*') counter++;
                        break;
                    }
                case 'L':
                    {
                            if (lab[row][col - 1] == '*') counter++;
                            if (lab[row + 1][col] == '*') counter++;
                            if (lab[row - 1][col] == '*') counter++;
                        break;
                    }
                case 'U':
                    {
                            if (lab[row][col + 1] == '*') counter++;
                            if (lab[row][col - 1] == '*') counter++;
                            if (lab[row + 1][col] == '*') counter++;
                        break;
                    }
            }
            if (lab[row][col + 1] != '*') counter++;
            if ( lab[row][col - 1] != '*') counter++;
            if ( lab[row + 1][col] != '*') counter++;
            if ( lab[row - 1][col] != '*') counter++;
            return counter;
        }
        public static void Mark(int row,int col,char direction)
        {
            var copy = lab[row].ToCharArray();
                if (lab[row][col]!=searchedSymbol)
            copy[col] = '*';
            lab[row] = string.Join("",copy);
        }
        public static bool IsFree(int row, int col,char direction)
        {
            switch (direction)
            {
                case 'D':
                    {
                        if (row < width - 1 && col > 0 && col < height - 1 && lab[row][col + 1] == '*' && lab[row][col - 1] == '*' && lab[row + 1][col] == '*')
                            return false;
                        else
                            return true;
                    }
                case 'R':
                    {
                        if (row<width-1 && row>0 && col<height-1&& lab[row][col + 1] == '*' && lab[row-1][col] == '*' && lab[row + 1][col] == '*')
                            return false;
                        else
                            return true;
                    }
                case 'L':
                    {
                        if (row < width - 1 && col > 0 && row >0 && lab[row-1][col] == '*' && lab[row][col - 1] == '*' && lab[row + 1][col] == '*')
                            return false;
                        else
                            return true;
                    }
                case 'U':
                    {
                        if (col >0 && row > 0 && col < height - 1 && lab[row][col + 1] == '*' && lab[row][col - 1] == '*' && lab[row -1 ][col] == '*')
                            return false;
                        else
                            return true;
                    }
            }return true;
        }
        public static bool IsVisited(int row, int col)
        {
            if (lab[row][col] == '*')
                return true;
            return false;
        }
        public static bool IsExit(int row, int col)
        {
            if (lab[row][col] == searchedSymbol)
                return true;
            return false;
        }
        public static bool IsInBounds(int row,int col)
        {
            if (row < 0 || col >= width || col < 0 || row >= height) return false;
            return true;
        }        
        public static int height = int.Parse(Console.ReadLine());
        public static int width = int.Parse(Console.ReadLine());
        public static string[] lab = new string[height];
        public static void DrawLab()
        {
            for (int i = 0; i < height; i++)
                lab[i] = Console.ReadLine();
        }
        public static List<char> path = new List<char>();
        public const char searchedSymbol = 'e';
        static void Main(string[] args)
        {
            DrawLab();
          FindPath(0, 0, 'S');
        }
    }
}
