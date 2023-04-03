using System;
using YoloSnake.Interfaces;

/// <summary>
/// Refactoring Task "Yolo Snake" Namespace.
/// </summary>
namespace YoloSnake.Core
{
    /// <summary>
    /// Yolo Snake Console drawer.
    /// </summary>
    public class ConsoleDrawer : IDrawer
    {
        /// <summary>
        ///  Yolo Snake draw single point in 2D space.
        /// </summary>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y Coordinate</param>
        /// <param name="symbol">Character to draw</param>
        public void DrawPoint(int x, int y, char symbol)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }
    }
}
