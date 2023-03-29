namespace CustomListSort
{
    public static class Console
    {
        public static void WriteLine<T>(T element)
        {
            var originalColor = System.Console.ForegroundColor;
            System.Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine(element);
            System.Console.ForegroundColor = originalColor;
        }

        public static string ReadLine()
        {
            return System.Console.ReadLine();
        }
    }
}
