using System;
namespace YoloSnake.Interfaces
{
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