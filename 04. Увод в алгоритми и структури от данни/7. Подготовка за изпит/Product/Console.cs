namespace Product
{
    public static class Console
    {
        /// <summary>
        /// Отпечатване на конзолата с зелен цвят
        /// </summary>
        public static void WriteLine(string text)
        {
            var color = System.Console.ForegroundColor;
            System.Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine(text);
            System.Console.ForegroundColor = color;
        }
    }
}
