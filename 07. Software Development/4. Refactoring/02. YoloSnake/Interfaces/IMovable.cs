namespace YoloSnake.Interfaces
{
    using Enums;
    public interface IMovable
    {
        Direction Direction
        {
            get;
        }
        void ChangeDirection(Direction newDirection);
        void Move();
    }
}