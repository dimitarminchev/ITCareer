using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageMaster
{
    public static class Console
    {
        public static void WriteLine(string text)
        {
            ConsoleColor consoleColor = System.Console.ForegroundColor;
            System.Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine(text);
            System.Console.ForegroundColor = consoleColor;
        }
    }
}
