namespace BonApetit
{
    static class Console
    {
        public static string ReadLine()
        {
            return System.Console.ReadLine();
        }

        public static void WriteLine(string text)
        {
            System.Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine(text);
            System.Console.ResetColor();
        }
    }
}
