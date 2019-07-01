using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ProgrammingLanguages
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().ToLower().Split().ToArray();
            var wordCounter = new Dictionary<string, int>();
            var oddCounter = new List<string>();

            foreach (var word in words)
            {
                if (wordCounter.ContainsKey(word))
                {
                    wordCounter[word]++; 
                }
                else wordCounter[word] = 1; 
            }

            foreach (var word in wordCounter)
            {
                if (word.Value % 2 != 0)
                {
                    oddCounter.Add(word.Key);
                }
            }

            Console.WriteLine(string.Join(", ", oddCounter));
        }
    }
}
