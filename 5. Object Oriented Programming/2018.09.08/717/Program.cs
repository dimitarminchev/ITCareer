using System;

namespace _717 {
    class Program {
        static void Main(string[] args) {
            var num = int.Parse(Console.ReadLine());
            var arr = Console.ReadLine().Split(' ');
            Console.WriteLine(string.Join("\n", arr.Where(w => w.Length <= num)));
        }
    }
}
