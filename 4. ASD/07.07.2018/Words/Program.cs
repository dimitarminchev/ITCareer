using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Words
{
    class Program
    {
        // 6.3. Думи
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();

            Recursion rec = new Recursion();
            rec.InputSet = rec.MakeCharArray(inputLine);
            rec.CalcPermutation(0);

            Console.WriteLine(rec.PermutationCount);
        }
    }
}
