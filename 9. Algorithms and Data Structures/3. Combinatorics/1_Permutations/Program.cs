using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _1_Permutations
{    
    class Program
    {
        // Task 1. Permutations
        public static BigInteger Permutations(BigInteger n)
        {
            if (n <= 1) return 1;
            return n*Permutations(n - 1);
        }

        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Permutations = {0}", Permutations(n));
        }
    }
}
