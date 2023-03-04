using YoloSnake.Interfaces;

namespace YoloSnake.Core
{
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