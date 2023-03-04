/// <summary>
/// Refactoring Task "Yolo Snake" Namespace.
/// </summary>
namespace YoloSnake.Interfaces
{
    /// <summary>
    /// Yolo Snake position interface.
    /// </summary>
    public interface IPosition
    {
        /// <summary>
        /// Yolo Snake X coordinate.
        /// </summary>
        int X { get; set; }

        /// <summary>
        /// Yolo Snake Y coordinate
        /// </summary>
        int Y { get; set; }

        /// <summary>
        /// Yolo Snake intersect method.
        /// </summary>
        /// <param name="other">Position paraeter.</param>
        /// <returns>Boolean: true or false</returns>
        bool Intersects(IPosition other);
    }
}