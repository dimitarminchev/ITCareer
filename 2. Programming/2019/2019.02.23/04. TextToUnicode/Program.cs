using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TextToUnicode
{
    class Program
    {
        static string TextToUnicode(string input)
        {
            string result = String.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                // string code = "\\u" + ((int)input[i]).ToString("X4"); // v1
                string code = "\\" + ((int)input[i]).ToString("X4"); // v2
                result = String.Concat(result, code.ToLower());
            }
            return result;
        }

        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var unicode = TextToUnicode(text);
            Console.WriteLine(unicode);
        }
    }
}
