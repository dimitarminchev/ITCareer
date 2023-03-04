using System;

/// <summary>
/// Refactoring Task "Yolo Snake" Namespace.
/// </summary>
namespace YoloSnake.Interfaces
{
    /// <summary>
    /// Yolo Snake kayboard handler interface.
    /// </summary>
    public interface IKeyboardHandler
    {
        /// <summary>
        /// Yolo Snake console pressed key.
        /// </summary>
        ConsoleKey PressedKey
        {
            get;
        }

        /// <summary>
        /// Yolo Snake is console key available.
        /// </summary>
        bool IsKeyAvailable
        { 
            get; 
        }
    }
}