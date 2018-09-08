using System;

namespace _719
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var index = arr.Length - 1;
            var list = Enumerable.Range(1, num).Select(s => (double)s);
            Console.WriteLine(string.Join(" ", list.Where(w => w / arr[index] == (int)(w / arr[index]))));
        }
    }
}
