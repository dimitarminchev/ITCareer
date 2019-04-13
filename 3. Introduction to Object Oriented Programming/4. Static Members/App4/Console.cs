using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4
{
    static class Console
    {
        // Вход
        public static string ReadLine()
        {
            return System.Console.ReadLine();
        }

        // Изход
        public static void WriteLine(string text)
        {
            System.Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine(text);
            System.Console.ResetColor();
        }
    }
}
