using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    // 03. Phoenix Grid (60/100)
    class Program
    {
        // Проверка за палиндром
        static bool Palindrome(string palindrome)
        {
            bool TrueOrFalse = false;
            for (int i = 0; i <= palindrome.Length / 2; i++)
            {
                if (palindrome[i] != palindrome[palindrome.Length - i - 1])
                {
                    TrueOrFalse = false;
                    break;
                }
                else TrueOrFalse = true;
            }
            return TrueOrFalse;
        }

        // Проверка за валиден вход
        static bool PhoenixGrid(String line)
        {
            try
            {
                List<string> tripples = new List<string>();
                for (int i = 0; i < line.Length; i += 4)
                {
                    tripples.Add(line.Substring(i, 3));
                }
                String text = String.Join("", tripples);
                if (text.Length % 3 != 0) return false;
                return Palindrome(text);
            }
            catch
            {
                return false;
            }
        }

        // Глаавна функция
        static void Main(string[] args)
        {
            String line = Console.ReadLine();
            while (line != "ReadMe")
            {
                if (PhoenixGrid(line)) Console.WriteLine("YES");
                else Console.WriteLine("NO");
                line = Console.ReadLine();
            }
        }
    }
}
