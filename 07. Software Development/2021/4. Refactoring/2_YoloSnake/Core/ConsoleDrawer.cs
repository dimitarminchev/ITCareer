namespace YoloSnake.Core
{
    using System;
    using Interfaces;
    public class ConsoleDrawer : IDrawer
    {
        public void DrawPoint(int x, int y, char symbol)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }
    }
}
