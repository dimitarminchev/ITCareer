using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1013_WorldsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, int>();

            using (StreamReader words = new StreamReader("words.txt"))
            {
                using (StreamReader text = new StreamReader("input.txt"))
                {
                    using (StreamWriter writer = new StreamWriter("output.txt"))
                    {
                        var line = text.ReadToEnd().ToLower().Split().ToArray();
                        var search = words.ReadToEnd().ToLower().Split().ToArray();                       
                        foreach (var item in search)
                        {
                            dict.Add(item, line.Count(x => x == item));
                        }
                        dict.OrderBy(x => x.Value);
                        foreach (var item in dict)
                        {
                            writer.WriteLine($"{item.Key} - {item.Value}");
                        }
                    }
                }
            }
            // Print
            Console.WriteLine(string.Join("\n", dict));
        }
    }
}
