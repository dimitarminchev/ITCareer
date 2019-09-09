using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_EgyptianFractions
{

    // Египетски дроби 
    class Program
    {


        static void Main(string[] args)
        {
            // Input (p=7,q=9)
            Console.Write("p=");
            int p = int.Parse(Console.ReadLine());
            Console.Write("q=");
            int q = int.Parse(Console.ReadLine());

            // Result
            Fraction goalFraction = new Fraction(p, q);
            Fraction currentSum = new Fraction(0, 1);
            Queue<Fraction> qFraction = new Queue<Fraction>();
            int part = 2;
            while (!(currentSum.Number == goalFraction.Number &&
                     currentSum.Denom == goalFraction.Denom))
            {
                var nextFraction = new Fraction(1, part);
                if (currentSum + nextFraction < goalFraction)
                {
                    currentSum += nextFraction;
                    qFraction.Enqueue(nextFraction);
                }
                part++;
            }

            // Print
            Console.Write(goalFraction + " = ");
            Console.WriteLine(string.Join(" + ",qFraction));
        }
    }
}
