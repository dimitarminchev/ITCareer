using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Word_Count_1009
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader readerWords = new StreamReader("words.txt");
            Dictionary<string, int> words = new Dictionary<string, int>();

            using (readerWords)
            {
                string line = readerWords.ReadLine();
                while (line != null)
                {
                    words.Add(line.ToLower(), 0);
                    line = readerWords.ReadLine();
                }
            }

            StreamReader textReader = new StreamReader("text.txt");

            using (textReader)
            {
                string[] line = textReader.ReadLine()
                    .Split(new char[] { ' ', '-', ',', '.' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                while (line != null)
                {
                    foreach (var word in line)
                    {
                        if (words.ContainsKey(word.ToLower()))
                        {
                            words[word.ToLower()]++;
                        }
                    }
                    string lineString = textReader.ReadLine();
                    if (lineString == null)
                    {
                        break;
                    }
                    else
                    {
                        line = lineString
                            .Split(new char[] { ' ', '-', ',', '.' }, StringSplitOptions.RemoveEmptyEntries)
                            .ToArray();
                    }

                }
            }

            StreamWriter resultWriter = new StreamWriter("result.txt");

            using (resultWriter)
            {
                foreach (var word in words.OrderByDescending(n => n.Value))
                {
                    resultWriter.Write("{0} - {1}", word.Key, word.Value);
                    resultWriter.WriteLine();
                }
            }
        }
    }
}