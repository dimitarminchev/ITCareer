using YoloSnake.Enums;

/// <summary>
/// Refactoring Task "Yolo Snake" Namespace.
/// </summary>
namespace YoloSnake.Interfaces
{
    /// <summary>
    /// Yolo Snake movable interface.
    /// </summary>
    public interface IMovable
    {
        /// <summary>
        /// Yolo Snake move method.
        /// </summary>
        void Move();

        /// <summary>
        /// Yolo Snake direction.
        /// </summary>
        Direction Direction { get; }

        /// <summary>
        /// Yolo Snake change direction method.
        /// </summary>
        /// <param name="newDirection">New direction parameter.</param>
        void ChangeDirection(Direction newDirection);
    }
}