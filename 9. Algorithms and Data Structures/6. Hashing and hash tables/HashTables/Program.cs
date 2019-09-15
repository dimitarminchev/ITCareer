using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    class Program
    {
        // Task 13. CountingSymbols
        static public void CountingSymbols()
        {
            string input = Console.ReadLine();
            var symbolCount = new HashTable<char, int>();
            foreach (var ch in input)
            {
                if (!symbolCount.ContainsKey(ch))
                {
                    symbolCount.Add(ch, 0);
                }
                symbolCount[ch]++;
            }

            foreach (var symbol in symbolCount.OrderBy(x => x.Key))
            {
                Console.WriteLine("{0}: {1} time{2}", symbol.Key, symbol.Value, symbol.Value > 1 ? "s" : string.Empty);
            }
        }

        // Task 14. PhoneBook
        static public void PhoneBook()
        {
            var phoneBook = new HashTable<string, string>();
            string inputLine = Console.ReadLine();

            while (inputLine != "search")
            {
                string[] parameters = inputLine.Split('-').ToArray();
                phoneBook.Add(parameters[0], parameters[1]);
                inputLine = Console.ReadLine();
            }

            inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                KeyValuePair<string, string> keyValuePair = phoneBook.Find(inputLine);
                if (keyValuePair == null)
                {
                    Console.WriteLine("Contact {0} does not exist.", inputLine);
                }
                else
                {
                    Console.WriteLine("{0} -> {1}", keyValuePair.Key, keyValuePair.Value);
                }
                inputLine = Console.ReadLine();
            }
        }

        static void Main(string[] args)
        {   
            // Input
            Console.WriteLine("Select task [13 or 14]:");
            var cmd = int.Parse(Console.ReadLine());
            switch (cmd)
            {
                case 13:
                    // Task 13. CountingSymbols
                    CountingSymbols();
                    break;
                case 14:
                    // Task 14. PhoneBook
                    PhoneBook();
                    break;
                default:
                    // Error case
                    Console.WriteLine("Wrong Task Number!");
                    break;
            }           
        }
    }
}
