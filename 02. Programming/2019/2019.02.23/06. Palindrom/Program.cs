using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Palindrom
{
    class Program
    {
        static bool Palindrom(string word)
        {
            string reversed = new string(word.Reverse().ToArray());
            if (word.CompareTo(reversed) == 0) return true;
            else return false;
        }

        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Console.WriteLine(Palindrom(word));
        }
    }
}
