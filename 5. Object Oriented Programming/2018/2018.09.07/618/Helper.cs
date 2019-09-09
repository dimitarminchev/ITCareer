using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _618
{
    public static class Helper
    {
        // Replaces Console.WriteLine
        public static void WriteLine(object text)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        // Replaces Console.Write
        public static void Write(object text)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(text);
            Console.ResetColor();
        }
    }
}
