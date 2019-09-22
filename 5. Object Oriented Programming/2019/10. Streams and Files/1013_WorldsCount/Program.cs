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
                using (StreamReader text = new StreamReader("TextFile1.txt"))
                {
                    using (StreamWriter writer = new StreamWriter("output.txt"))
                    {
                        var line = text.ReadToEnd().ToLower().Split(' ','?',',','.','-','!').ToArray();
                        var search = words.ReadLine();
                        while (search != null)
                        {
                            dict.Add(search, line.Count(x => x == search));
                            search = words.ReadLine();
                        }
                        dict = dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
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