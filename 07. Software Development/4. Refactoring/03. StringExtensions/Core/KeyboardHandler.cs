namespace YoloSnake.Core
{
    using System;
    using Interfaces;

    public class KeyboardHandler : IKeyboardHandler
    {
        public ConsoleKey PressedKey
        {
            get
            {
                return Console.ReadKey().Key;
            }
        }

        public bool IsKeyAvailable
        {
            get
            {
                return Console.KeyAvailable;
            }
        }
    }
}