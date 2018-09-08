using System;

namespace _716
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var num = double.Parse(Console.ReadLine());
            Console.WriteLine(string.Join(" ", list.Reverse().Where(w => w / num != (int)(w / num))));
        }
    }
}
