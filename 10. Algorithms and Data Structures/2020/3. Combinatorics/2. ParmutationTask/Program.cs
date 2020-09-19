using System;
using System.Numerics;

namespace _2._ParmutationTask
{
    class Program
    {
        /*
        Изчислете броя на пермутациите за дадена стойност на N. 
        Известно е, че броят на пермутациите е равен на факториела на N, 
        т.е. N! = 1.2.3...N.  Рекурсивната дефиниция е N!=N*(N-1).
         */
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // 7 -> 5040
            BigInteger result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }
    }
}
