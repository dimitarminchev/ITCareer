using System;
using System.Linq;

namespace _13.Warehouse
{
    class Program
    {
        // 13. Склад
        static void Main(string[] args)
        {
            var products = Console.ReadLine().Split().ToArray();
            var quantities = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var prices = Console.ReadLine().Split().Select(float.Parse).ToArray();

            while (true)
            {
                var cmd = Console.ReadLine();
                if (cmd == "done") break;

                var search = Search(products, cmd);
                if (search != -1)
                    Console.WriteLine("{0} costs: {1}; Available quantity: {2}",
                             products[search], prices[search], quantities[search]);
            }

        }

        // Търсене на продукт
        static int Search(string[] products, string product)
        {
            for (int index = 0; index < products.Length; index++)
                if (products[index] == product) return index;
            return -1;
        }
    }
}
