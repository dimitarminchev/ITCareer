/// <summary>
/// Refactoring Task "Yolo Snake" Namespace.
/// </summary>
namespace YoloSnake.Interfaces
{
    /// <summary>
    /// Yolo Snake draw point interface.
    /// </summary>
    public interface IDrawer
    {
        /// <summary>
        /// Yolo Snake draw point method.
        /// </summary>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        /// <param name="symbol">Character to draw</param>
        void DrawPoint(int x, int y, char symbol);
    }
}