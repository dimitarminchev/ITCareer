public static class Console
{
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

    public static string ReadLine()
    {
        return System.Console.ReadLine();
    }
}