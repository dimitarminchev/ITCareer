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
            using (StreamReader words = new StreamReader("words.txt"))
            {
                using (StreamReader text = new StreamReader("text.txt"))
                {
                    using (StreamWriter writer = new StreamWriter("result.txt"))
                    {
                        var line = text.ReadToEnd().ToLower().Split().ToArray();
                        var search = words.ReadToEnd().ToLower().Split().ToArray();
                        var dict = new Dictionary<string, int>();
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
        }
    }
}
