using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.NakovGame
{
    class Program
    {
        // TODO: Find a fix for some of the Exmaples
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var sum = 0d;
            foreach (var a in input)
            {
                var b = double.Parse(a.Substring(1, a.Length - 2));
                var l1 = Char.IsLower(a.First());
                var l2 = Char.IsLower(a.Last());

                b *= (l1 ? a.ToLower().First() - 96 : 1 / (a.ToLower().First() - 96));
                b += (l2 ? a.ToLower().Last() - 96 : -(a.ToLower().Last() - 96));

                sum += b;
            }
            Console.WriteLine("{0:f2}",sum);
        }
    }
}
