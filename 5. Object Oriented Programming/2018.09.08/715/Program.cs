using System;

namespace _715 {
    class Program {
        static void Main(string[] args) {
            var list = Console.ReadLine().Split(' ').Select(int.Parse);
            string input;
            while((input = Console.ReadLine()) != "end")
                switch(input) {
                    case "print":
                        Console.WriteLine(string.Join(" ", list));
                        break;
                    case "add":
                        list = list.Select(s => ++s);
                        break;
                    case "substract":
                        list = list.Select(s => --s);
                        break;
                    case "multiply":
                        list = list.Select(s => s *= 2);
                        break;
                }
        }
    }
}
