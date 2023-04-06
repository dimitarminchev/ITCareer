using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            // HashTable
            var hashtable = new HashTable<char, int>();

            // Add data
            for (int i = 65; i < 91; i++)
            {
                hashtable.Add((char)i, i);
            }

            // Print
            Console.WriteLine("ASCII");
            foreach (var item in hashtable)
            {
                Console.WriteLine("{0} = {1}", item.Key, item.Value);
            }
        }
    }
}
