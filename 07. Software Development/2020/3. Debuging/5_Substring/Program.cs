using System;

/// <summary>
/// 3. Debuging, 5. Sub String
/// </summary>
namespace _5_Substring
{
    /// <summary>
    /// Main Program Class: 3. Debuging, 5. Sub String
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Input:
        /// preparation
        /// 4
        /// Output:
        /// prepra
        /// </summary>
        public static void Main()
        {
            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine());

            const char Search = 'p';
            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == Search)
                {
                    hasMatch = true;
                    int length = jump+1;
                    if (length +1+i> text.Length)
                    {
                        length = text.Length-i;
                    }
                    string matchedString = text.Substring(i, length);
                    Console.WriteLine(matchedString);
                    i += jump;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
