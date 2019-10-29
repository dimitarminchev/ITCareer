using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _702
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string[]> input =()=> Console.ReadLine().Split(new[] {' '},StringSplitOptions.RemoveEmptyEntries).ToArray();
            Action<string[]> output=(inp)=> Console.WriteLine("Sir "+string.Join("\nSir ",inp));
            output(input());
        }
    }
}
