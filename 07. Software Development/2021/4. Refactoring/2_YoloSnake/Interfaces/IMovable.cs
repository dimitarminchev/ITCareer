namespace YoloSnake.Interfaces
{
    using Enums;
    public interface IMovable
    {
        void Move();
        Direction Direction { get; }
        void ChangeDirection(Direction newDirection);
    }
}