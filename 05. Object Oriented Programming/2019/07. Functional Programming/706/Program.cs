using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _706
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int divider = int.Parse(Console.ReadLine());

            Func<int, bool> checker = n => n % divider != 0;


            numbers = numbers.Where(checker).ToList();
            numbers.Reverse();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
