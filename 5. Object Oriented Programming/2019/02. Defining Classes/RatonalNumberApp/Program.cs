using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatonalNumberApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input: 3 4 3 6 25 100
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            // Rational Number List
            List<RationalNumber> rationals = new List<RationalNumber>();

            // Process ...         
            for (int i = 0; i < input.Length; i += 2)
            {
                rationals.Add
                (
                    new RationalNumber(input[i], input[i + 1])
                );
            }

            // Output: 3/4; 1/2; 1/4
            Console.WriteLine(string.Join("; ", rationals));
        }            
    }
}
