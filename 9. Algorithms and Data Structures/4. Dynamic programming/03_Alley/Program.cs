using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Alley
{
    class Program
    {
        static int alleyLength;
        static int[] allowedTileLengths;
        static BigInteger counter;
        static void SolveAlley(int remainingMeters)
        {
            if (remainingMeters == 0)
            {
                counter++;
                return;
            }
            else if (remainingMeters > 0)
            {
                for (int i = 0; i < allowedTileLengths.Length; i++)
                {
                    if (remainingMeters - allowedTileLengths[i] >= 0)
                    {
                        SolveAlley(remainingMeters - allowedTileLengths[i]);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            alleyLength = Console.ReadLine().Split().Select(int.Parse).ToArray()[0];
            allowedTileLengths = Console.ReadLine().Split().Select(int.Parse).ToArray();
            counter = new BigInteger(0);
            SolveAlley(alleyLength);
            Console.WriteLine(counter);
        }
    }
}