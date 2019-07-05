using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _616
{
    class Program
    {
        //Автор: Цветилин Цветилов
        // 616 = Arrays in Matrix
        public static int row = int.Parse(Console.ReadLine());
        public static int col = int.Parse(Console.ReadLine());
        public static string[] table = new string[row];
        public static List<Region> regions = new List<Region>();
        public static void Draw()
        {
            for (int i = 0; i < row; i++)
            {
                table[i] = Console.ReadLine();
            }
        }
        public static void FindStartingPoints()
        {
            for (int i = 0; i < row; i++)
            {
                for (int y = 0; y < col; y++)
                {
                    if (table[i][y] == '-')
                    {
                        if (y == 0 && i == 0) regions.Add(new Region(y, i));
                        else if (y == 0) { if (table[i - 1][y] == '*') regions.Add(new Region(y, i)); }
                        else if (i == 0) { if (table[i][y - 1] == '*') regions.Add(new Region(y, i)); }
                        else if (table[i - 1][y] == '*' && table[i][y - 1] == '*') regions.Add(new Region(y, i));
                    }
                }
            }

        }
        public static void Check()
        {
            for (int ind = 0; ind < regions.Count; ind++)
            {
                int startX = regions[ind].X;
                int startY = regions[ind].Y;
                int area = 0;
                //bool first = true;
                for (; true; startY++)
                {

                    // TODO: Проверка за стени с разминаване на елемените >=1
                    //     *----*         **----*----*
                    //     *--*-*         *-*--*-----*
                    //     *-**-*         *-----*----*
                    //     ******         ************
                    //      A=9           A1=12   A2=13

                    while (startX > 0 && startY != 0)
                    {
                        if (table[startY][startX - 1] == '-') startX--;
                        //else if(!first && table[startY-1][startX ] == '*'&& table[startY][startX] == '-'){startX--;}
                        else if (startX - 2 >= 0)
                        { if ((table[startY][startX - 1] == '*' && table[startY - 1][startX - 1] == '-' && table[startY - 1][startX] == '-' && table[startY - 1][startX - 2] == '-')) startX--; else break; }
                        else break;
                    }
                    //first = false;
                    for (; true; startX++)
                    {
                        if (startX == col) break;
                        Console.WriteLine(startY + " " + startX);

                        if (table[startY][startX] == '-')
                        {
                            var temp = table[startY].ToCharArray();
                            temp[startX] = '*';
                            table[startY] = string.Join("",temp);
                            area++;
                        }

                        else break;
                    }
                    if (startY + 1 == row) break;
                }
            }
        }
        public static void Print()
        {
            foreach (var item in regions)
            {
                Console.WriteLine(item.X + " " + item.Y + " " + item.Area);
            }
        }
        static void Main(string[] args)
        {
            Draw();
            FindStartingPoints();
            Check();
        }
    }
}
