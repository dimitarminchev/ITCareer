namespace Matrix
{
    class Region
    {
        public int X { get; set; }

        public int Y { get; set; }

        public int Area { get; set; }

        public Region(int x, int y)
        {
            X = x;
            Y = y;
            Area = 1;
        }
    }
}