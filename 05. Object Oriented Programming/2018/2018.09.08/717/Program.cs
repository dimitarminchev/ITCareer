using System;
using System.Linq;
using System.Text;

namespace _717
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split().ToArray();

            Predicate<string> goodLength = n => n.Length <= length;
            Func<string[], string> print = x =>
            {
                StringBuilder toReturn = new StringBuilder();
                foreach (var name in x)
                {
                    if (goodLength(name))
                        toReturn.AppendLine(name);
                }
                return toReturn.ToString();
            };

            Console.Write(print(names));
        }
    }
}
