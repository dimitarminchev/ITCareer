namespace Vehicles2
{
    public static class Console
    {
        public static void WriteLine(string line)
        {
            var color = System.Console.ForegroundColor;
            System.Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine(line);
            System.Console.ForegroundColor = color;
        }
    }
}