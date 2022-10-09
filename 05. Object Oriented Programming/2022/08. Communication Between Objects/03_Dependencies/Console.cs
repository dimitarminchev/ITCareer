public static class Console
{
    /// <summary>
    /// Отпечатване на ред в конзолата
    /// </summary>
    public static void WriteLine(string s)
    {
        // 1. Взимаме текущия цвят на текста
        var color = System.Console.ForegroundColor;

        // 2. Сменяме текущият цвят на текса на зелен
        System.Console.ForegroundColor = ConsoleColor.Green;

        // 3. Отпечатваме текста
        System.Console.WriteLine(s);

        // 4. Връщаме оригиналният цвят на текста
        System.Console.ForegroundColor = color;
    }
}