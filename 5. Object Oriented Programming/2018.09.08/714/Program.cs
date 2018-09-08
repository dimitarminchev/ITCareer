using System;

namespace _714
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var oddEven = Console.ReadLine();
            Console.WriteLine
            (
                string.Join(" ", Enumerable.Predicate
                (
                    int.Parse(input[0]),
                    int.Parse(input[1]),
                    f => f % 2 == (oddEven == "even" ? 0 : 1)
                ))
            );
        }
    }
}
