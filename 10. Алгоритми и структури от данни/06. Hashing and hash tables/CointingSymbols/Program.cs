using System;
using System.Linq;

namespace CointingSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string symbols = Console.ReadLine();

            var symbolCount = new HashTable<char, int>();

            foreach (var symbol in symbols)
            {
                if (!symbolCount.ContainsKey(symbol))
                {
                    symbolCount.Add(symbol, 0);
                }
                symbolCount[symbol]++;
            }

            var orderedSymbolCount = symbolCount.OrderBy(x => x.Key).ToList();

            foreach (KeyValue<char, int> symbol in orderedSymbolCount)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}
