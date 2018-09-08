using System;

namespace _718
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var arr1 = arr.Where(w => w % 2 == 0);
            var arr2 = arr.Where(w => w % 2 != 0);
            Console.WriteLine
            (
                string.Join(" ", arr1.OrderBy(o => o)) + " " +
                string.Join(" ", arr2.OrderBy(o => o))
            );
        }
    }
}
