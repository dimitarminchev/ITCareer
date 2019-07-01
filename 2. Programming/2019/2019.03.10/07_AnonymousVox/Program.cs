using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07_AnonymousVox
{
    class Program
    {
        static void Main(string[] args)
        {
            var placeholderRegex = new Regex(@"([A-Za-z]+).+\1");
            var valueRegex = new Regex(@"{(.+?)}");

            string text = Console.ReadLine();
            string valuesText = Console.ReadLine();

            var values = valueRegex.Matches(valuesText);
            int i = 0;
            text = placeholderRegex.Replace(text, m =>
            {
                if (i < values.Count)
                    return $"{m.Groups[1].Value}{values[i++].Groups[1].Value}{m.Groups[1].Value}"; // i++ returns i and increments it
                return m.Value;
            });
            Console.WriteLine(text);

        }
    }
}
