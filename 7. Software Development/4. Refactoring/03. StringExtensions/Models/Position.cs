namespace YoloSnake.Models
{
    using Interfaces;

    public class Position : IPosition
    {
        public Position(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int X
        {
            get;
            set;
        }

        public int Y
        {
            get;
            set;
        }

        public bool Intersects(IPosition other)
        {
            return this.X == other.X 
                && this.Y == other.Y;
        }
    }
}