using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Substring
{
    class Program
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine());

            const char Search = 'p'; // Fix: Some asshole put the Bulgarian symbol р instead of the English symbol p
            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == Search)
                {
                    hasMatch = true;

                    // Fix: No need for EndIndex at all, .Substring() does not accept endIndex parameter                   
                    string matchedString = text.Substring
                                           (
                                                i, 
                                                Math.Min (jump + 1, text.Length - i)
                                           ); // Fix: Will stop at the end if the string doesn't have enough characters to print out
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
