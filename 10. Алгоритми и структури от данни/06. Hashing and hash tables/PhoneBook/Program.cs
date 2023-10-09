using System;
using System.Linq;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new HashTable<string, string>();

            string inputLine = Console.ReadLine();
            while (inputLine != "search")
            {
                var parts = inputLine.Split('-').ToArray(); 
                phoneBook.Add(parts[0], parts[1]); // 0 = name, 1 = phone
                inputLine = Console.ReadLine();
            }

            inputLine = Console.ReadLine();
            while (inputLine != "end")
            {
                KeyValue<string, string> pair = phoneBook.Find(inputLine);
                if (pair == null)
                {
                    Console.WriteLine($"Contact {inputLine} does not exist.");
                }
                else 
                {
                    Console.WriteLine($"{pair.Key} -> {pair.Value}");
                }
                inputLine = Console.ReadLine();
            }
        }
    }
}
