using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    class Program
    {
        /* Свързан списък */
        static void Main(string[] args)
        {
            // Създаваме свързан списък
            DinamicList list = new DinamicList();

            // Зареждаме съдържание
            list.Add("zero");
            list.Add("one");
            list.Add("two");
            list.Add("three");

            // Тестваме списъка
            Console.WriteLine(list.Count);           // 4
            Console.WriteLine(list[0]);              // zero
            Console.WriteLine(list.IndexOf("two"));  // 2
            Console.WriteLine(list.Remove(1));       // one
            Console.WriteLine(list.Count);           // 3
            Console.WriteLine(list.Remove("three")); // 2 
            Console.WriteLine(list.Count);           // 2
            Console.WriteLine(list.Remove("four"));	 // -1

        }
    }
}
