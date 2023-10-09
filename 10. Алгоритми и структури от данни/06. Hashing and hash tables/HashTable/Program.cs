using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var hashtable = new HashTable<char, int>();

            for (int i = 65; i < 91; i++)
            {
                hashtable.Add((char)i, i);
            }

            Console.WriteLine("ASCII Table");
            foreach (var item in hashtable)
            {
                Console.WriteLine("{0} = {1}", item.Key, item.Value);
            }
        }
    }
}
