using YoloSnake.Enums;

namespace YoloSnake.Interfaces
{
    public interface IMovable
    {
        void Move(); 
        
        Direction Direction { get; }

        void ChangeDirection(Direction newDirection);
    }
}