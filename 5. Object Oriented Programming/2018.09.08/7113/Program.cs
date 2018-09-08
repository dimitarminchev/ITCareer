using System;

namespace _7113 {
    class Program {
        static void Main(string[] args) {
            var num = int.Parse(Console.ReadLine());
            var list = Console.ReadLine().Split(' ');
            Console.WriteLine(list.FirstOrDefault(w => w.Select(s => (int)s).Sum() >= num));
        }
    }
}
