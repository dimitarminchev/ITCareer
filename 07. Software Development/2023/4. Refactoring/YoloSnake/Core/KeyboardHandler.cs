using YoloSnake.Interfaces;

/// <summary>
/// Refactoring Task "Yolo Snake" Namespace.
/// </summary>
namespace YoloSnake.Core
{
    /// <summary>
    /// Yolo Snake keyboard handler.
    /// </summary>
    public class KeyboardHandler : IKeyboardHandler
    {
        /// <summary>
        /// Yolo Snake console read pressed key.
        /// </summary>
        public ConsoleKey PressedKey
        {
            get
            {
                return Console.ReadKey().Key;
            }
        }


        /// <summary>
        /// Yolo Snake is console key avalable.
        /// </summary>
        public bool IsKeyAvailable
        {
            get
            {
                return Console.KeyAvailable;
            }
        }
    }
}