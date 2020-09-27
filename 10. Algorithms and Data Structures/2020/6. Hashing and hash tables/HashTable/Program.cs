using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 13. Cointing Symbols

            // Input
            string symbols = Console.ReadLine();

            // Process
            var symbolCount = new HashTable<char, int>();
            foreach (var symbol in symbols)
            {
                if (!symbolCount.ContainsKey(symbol))
                {
                    symbolCount.Add(symbol, 0);
                }
                symbolCount[symbol]++;
            }

            // Print
            foreach (var item in symbolCount)
            {
                Console.WriteLine("{0}: {1} time/s", item.Key, item.Value);
            }
        }
    }
}
