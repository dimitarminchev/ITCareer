using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Greetings
{
    class Program
    {
        // 16. Поздрав
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine ($"Hello, {firstName} {lastName}.\r\nYou are {age} years old.");

        }
    }
}
