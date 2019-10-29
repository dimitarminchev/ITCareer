using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _703
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[]> input = () => Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Action<int[]> output = (inp) => Console.WriteLine(inp.Min());
            output(input());
        }
    }
}
