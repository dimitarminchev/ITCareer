namespace YoloSnake.Interfaces
{
    public interface IPosition
    {
        int X { get; set; }

        int Y { get; set; }

        bool Intersects(IPosition other);
    }
}