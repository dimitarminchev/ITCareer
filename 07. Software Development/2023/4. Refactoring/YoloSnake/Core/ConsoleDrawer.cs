using System;
using YoloSnake.Interfaces;

namespace YoloSnake.Core
{
    public class ConsoleDrawer : IDrawer
    {
        public void DrawPoint(int x, int y, char symbol)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }
    }
}
