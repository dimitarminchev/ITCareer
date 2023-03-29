namespace Telephony
{
    static class Console
    {
        public static void WriteLine(object text)
        {
            System.Console.ForegroundColor = ConsoleColor.Cyan;
            System.Console.WriteLine(text);
            System.Console.ResetColor();
        }
    }
}
