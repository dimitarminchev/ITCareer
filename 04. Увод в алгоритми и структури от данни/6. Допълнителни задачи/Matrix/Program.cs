namespace Matrix
{
    class Program
    {
        private static int row = int.Parse(Console.ReadLine());
        private static int col = int.Parse(Console.ReadLine());
        private static string[] table = new string[row];
        private static List<Region> regions = new List<Region>();
        private static int Counter = 0;

        private static void ReadTable()
        {
            for (int i = 0; i < row; i++)
            {
                table[i] = Console.ReadLine();
            }
        }

        private static void FindStartingPoint()
        {
            for (int x = 0; x < row; x++)
            {
                for (int y = 0; y < col; y++)
                {
                    if (table[x][y] == '-')
                    {
                        if (x == 0 && y == 0) regions.Add(new Region(y, x));
                        else if (y == 0) { if (table[x - 1][y] == '*') regions.Add(new Region(y, x)); }
                        else if (x == 0) { if (table[x][y - 1] == '*') regions.Add(new Region(y, x)); }
                        else if (table[x - 1][y] == '*' && table[x][y - 1] == '*') regions.Add(new Region(y, x));
                    }
                }
            }
        }

        private static void PrintRegions()
        {
            foreach (var region in regions)
            {
                Console.WriteLine($"{region.X} {region.Y} {region.Area}"); // ?
            }
        }

        private static void RegionCheck(int x, int y)
        {
            if (IsCellInReagionBounds(x, y) && table[y][x] != '*')
            {
                MarkCellInRegion(x, y);
                RegionCheck(x, y + 1);
                RegionCheck(x + 1, y);
                RegionCheck(x, y - 1);
                RegionCheck(x - 1, y);
            }
        }

        private static bool IsCellInReagionBounds(int x, int y)
        {
            if (x < 0 || y >= row || y < 0 || x >= col) return false;
            else return true;
        }

        private static void MarkCellInRegion(int x, int y)
        {
            var temp = table[y].ToCharArray();
            temp[x] = '*';
            table[y] = string.Join("", temp);
            Counter++;
        }

        public static void Main(string[] args)
        {
            ReadTable();
            FindStartingPoint();
            for (int i = 0; i < regions.Count; i++)
            {
                int x = regions[i].X;
                int y = regions[i].Y;
                Counter = 0;
                RegionCheck(x, y);
                regions[i].Area = Counter;
            }
            regions = regions.Where(x => x.Area != 0).OrderByDescending(y => y.Area).ToList();
            PrintRegions();
        }
    }

}