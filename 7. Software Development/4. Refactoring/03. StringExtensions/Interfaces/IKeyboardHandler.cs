namespace YoloSnake.Interfaces
{
    using System;

    /// <summary>
    /// Интерфейс за работа с клавиатурата
    /// </summary>
    public interface IKeyboardHandler
    {
        /// <summary>
        /// Последно натиснат клавиш
        /// </summary>
        ConsoleKey PressedKey { get; }

        /// <summary>
        /// Клавишът достъпен ли е?
        /// </summary>
        bool IsKeyAvailable { get; }
    }
}