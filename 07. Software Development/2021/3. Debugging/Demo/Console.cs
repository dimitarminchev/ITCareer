namespace Demo
{
    internal static class Console
    {
        /// <summary>
        /// Метод за отпечатване
        /// </summary>
        /// <param name="message">Съобщение</param>
        public static void WriteLine(object message)
        {
            // Отпечатваме съобщение
            System.Console.WriteLine(message);
        }

        /// <summary>
        /// Метод за негативно отпечатване
        /// </summary>
        /// <param name="message">Съобщение</param>
        public static void WriteNegative(object message)
        {
            // Текущи стойности на цвета на конзолята
            var bc = System.Console.BackgroundColor;
            var fc = System.Console.ForegroundColor;

            // Смяна на цвета на конзолата
            System.Console.BackgroundColor = System.ConsoleColor.Green;
            System.Console.ForegroundColor = System.ConsoleColor.Black;

            // Отпечатваме съобщение
            System.Console.WriteLine(message);

            // Връщане на оригиналните настройки
            System.Console.BackgroundColor = bc;
            System.Console.ForegroundColor = fc;
        }
    }
}
