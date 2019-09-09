using System;

namespace _7110
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ');
            string[] input;
            while ((input = Console.ReadLine().Split(' '))[0] != "Party!")
                switch (input[0])
                {
                    case "Remove":
                        if (input[1] == "StartsWith")
                            list = list.Where(w => !w.StartsWith(input[2])).ToArray();
                        break;
                    case "Double":
                        if (input[1] == "Length")
                        {
                            var length = int.Parse(input[2]);
                            list = list.Double(w => w.Length == length).ToArray();
                        }
                        if (input[1] == "StartsWith")
                            list = list.Double(w => w.StartsWith(input[2])).ToArray();
                        if (input[1] == "EndsWith")
                            list = list.Double(w => w.EndsWith(input[2])).ToArray();
                        break;
                }
            Console.WriteLine(list.Length == 0 ? "Nobody is going to the party!" :
                string.Join(", ", list) + " are going to the party!");
        }
    }
}
