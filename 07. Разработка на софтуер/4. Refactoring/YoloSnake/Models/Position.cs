using YoloSnake.Interfaces;

/// <summary>
/// Refactoring Task "Yolo Snake" Namespace.
/// </summary>
namespace YoloSnake.Models
{
    /// <summary>
    /// Yolo Snake position class
    /// </summary>
    public class Position : IPosition
    {

        /// <summary>
        /// Yolo Snake position class constructor.
        /// </summary>
        /// <param name="x">X coordinate parameter</param>
        /// <param name="y">Y coordinate parameter</param>
        public Position(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Yolo Snake X coordinate
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Yolo Snake Y coordinate
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Yolo Snake intersect method.
        /// </summary>
        /// <param name="other">Position parameter</param>
        /// <returns>Boolean: true or false</returns>
        public bool Intersects(IPosition other)
        {
            return this.X == other.X && this.Y == other.Y;
        }
    }
}