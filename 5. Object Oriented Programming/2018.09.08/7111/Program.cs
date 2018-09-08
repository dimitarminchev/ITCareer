using System;

namespace _7111 {
    class Program {
        static void Main(string[] args) {
            var list = Console.ReadLine().Split(' ').ToList();
            var copy = list.ToArray();
            string[] input;
            while((input = Console.ReadLine().Split(';'))[0] != "Print")
                switch(input[0]) {
                    case "Remove filter":
                        if(input[1] == "Starts with") {
                            var removed = copy.Where(w => w.StartsWith(input[2])).ToList();
                            list = copy.Where(w => list.Contains(w) || removed.Contains(w)).ToList();
                        }
                        break;
                    case "Add filter":
                        if(input[1] == "Starts with")
                            list = list.Where(w => !w.StartsWith(input[2])).ToList();
                        break;
                }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
