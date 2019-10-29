using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SuperMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,KeyValuePair <double, int>> products = new Dictionary<string, KeyValuePair<double, int>>();
            var input = Console.ReadLine().Split().ToArray();
            while (input[0] != "stocked")
            {
                    products.Add(input[0],new KeyValuePair<double,int>(double.Parse(input[1]),int.Parse(input[2])));
                input = Console.ReadLine().Split().ToArray();
            }
            double total=0;
            foreach (var item in products)
            {
                Console.WriteLine("{0}: ${1:f2} * {2} = ${3:f2}",item.Key,item.Value.Key,2,item.Value.Value,item.Value.Value*item.Value.Key);
                total += item.Value.Value * item.Value.Key;
            }
            Console.WriteLine("------------------------------\nGrand Total: ${0:f2}",total,2);
        }
    }
}
