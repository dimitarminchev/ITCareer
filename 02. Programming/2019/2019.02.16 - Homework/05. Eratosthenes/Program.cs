using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            // Масив съдържащ прости числа
            bool[] primes = new bool[n + 1];
            for (int index = 0; index <= n; index++)
            {
                primes[index] = true;
            }
            primes[0] = primes[1] = false;

            // Алгоритъм на Ереатостен за прости числа
            int p = 0;
            while (true)
            {
                bool nextPrimeNotFound = true;
                for (int index = p+1; index <= n; index++)
                {
                    if (primes[index])
                    {
                        p = index;
                        nextPrimeNotFound = false;
                        break;
                    }
                }
                if (nextPrimeNotFound) return;

                Console.Write("{0} ",p);

                for (int index = 2; index*p <= n; index++)
                {
                    primes[index * p] = false;
                }
            }
        }
    }
}
