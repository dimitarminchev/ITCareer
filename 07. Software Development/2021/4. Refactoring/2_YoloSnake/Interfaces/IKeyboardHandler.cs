namespace YoloSnake.Interfaces
{
    using System;

    /// <summary>
    /// Yolo Snake kayboard handler interface.
    /// </summary>
    public interface IKeyboardHandler
    {
        /// <summary>
        /// Yolo Snake console pressed key.
        /// </summary>
        ConsoleKey PressedKey { get; }

        /// <summary>
        /// Yolo Snake is console key available.
        /// </summary>
        bool IsKeyAvailable { get; }
    }

}