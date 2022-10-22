public static class Console
{
    /// <summary>
    /// Console.WriteLine
    /// </summary>
    public static void WriteLine(string s)
    {
        var color = System.Console.ForegroundColor;
        System.Console.ForegroundColor = ConsoleColor.Green;
        System.Console.WriteLine(s);
        System.Console.ForegroundColor = color;
    }

    /// <summary>
    /// Console.ReadLine
    /// </summary>
    public static string ReadLine()
    {
        return System.Console.ReadLine();
    }
}