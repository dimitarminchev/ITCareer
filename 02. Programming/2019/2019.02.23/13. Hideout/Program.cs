using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Hideout
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            while (true)
            {
                var line = Console.ReadLine().Split().ToArray();
                var ch = char.Parse(line[0]);
                var count = int.Parse(line[1]);

                if (text.Contains(new string(ch, count)))
                {
                    var indexOfTheFirstChar = text.IndexOf(new string(ch, count));
                    var lengthOfTheFoundString = count;

                    for (int i = indexOfTheFirstChar + count; i < text.Length; i++)
                        if (text[i] == ch)
                            lengthOfTheFoundString++;

                    Console.WriteLine($"Hideout found at index {indexOfTheFirstChar} and it is with size {lengthOfTheFoundString}!");
                    
                }
            }
        }
    }
}
