using System;
using System.Linq;

namespace PhoneBook
{
    class Program
    {
        // PhoneBook
        static void Main(string[] args)
        {
            // Data Structure
            var phoneBook = new HashTable<string, string>();

            // Input contacts
            string inputLine = Console.ReadLine();
            while (inputLine != "search")
            {
                var parts = inputLine.Split('-').ToArray(); 
                phoneBook.Add(parts[0], parts[1]); // 0 = name, 1 = phone
                inputLine = Console.ReadLine();
            }

            // Process commands
            inputLine = Console.ReadLine();
            while (inputLine != "end")
            {
                KeyValue<string, string> pair = phoneBook.Find(inputLine);
                if (pair == null)
                {
                    Console.WriteLine("Contact {0} does not exist.", inputLine);
                }
                else 
                {
                    Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
                }
                inputLine = Console.ReadLine();
            }
        }
    }
}
