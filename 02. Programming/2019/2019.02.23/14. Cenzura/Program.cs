using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Cenzura
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] banWords = Console.ReadLine().Split(' '); 
            string text = Console.ReadLine();
            foreach (var banWord in banWords)
            {
                if (text.Contains(banWord))
                {
                    text = text.Replace(banWord,
                      new string('*', banWord.Length));
                }
            }
            Console.WriteLine(text);

        }
    }
}
