namespace Substring
{
    internal static class Console
    {
        /// <summary>
        /// Метод за отпечатване
        /// </summary>
        /// <param name="message">Съобщение</param>
        public static void WriteLine(object message)
        {
            // Текущи стойности на цвета на конзолята
            var fc = System.Console.ForegroundColor;

            // Смяна на цвета на конзолата
            System.Console.ForegroundColor = System.ConsoleColor.Yellow;

            // Отпечатваме съобщение
            System.Console.WriteLine(message);

            // Връщане на оригиналните настройки
            System.Console.ForegroundColor = fc;
        }

        /// <summary>
        /// Метод за отпечатване
        /// </summary>
        /// <param name="message">Съобщение</param>
        public static void Write(object message)
        {
            // Текущи стойности на цвета на конзолята
            var fc = System.Console.ForegroundColor;

            // Смяна на цвета на конзолата
            System.Console.ForegroundColor = System.ConsoleColor.Yellow;

            // Отпечатваме съобщение
            System.Console.Write(message);

            // Връщане на оригиналните настройки
            System.Console.ForegroundColor = fc;
        }
    }
}
