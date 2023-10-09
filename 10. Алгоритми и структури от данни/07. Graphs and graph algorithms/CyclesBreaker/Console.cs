namespace CyclesBreaker
{
    public static class Console
    {
        public static void WriteLine<T>(T output)
        {
            var originalColor = System.Console.ForegroundColor;
            System.Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine(output);
            System.Console.ForegroundColor = originalColor;
        }

        public static void Write<T>(T output)
        {
            var originalColor = System.Console.ForegroundColor;
            System.Console.ForegroundColor = ConsoleColor.Green;
            System.Console.Write(output);
            System.Console.ForegroundColor = originalColor;
        }

        public static string ReadLine() => System.Console.ReadLine();
    }
}