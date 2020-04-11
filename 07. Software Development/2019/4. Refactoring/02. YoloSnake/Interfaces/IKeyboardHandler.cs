namespace YoloSnake.Interfaces
{
    using System;
    public interface IKeyboardHandler
    {
        ConsoleKey PressedKey
        {
            get;
        }

        bool IsKeyAvailable
        {
            get;
        }
    }

}