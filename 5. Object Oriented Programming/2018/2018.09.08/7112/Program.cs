using System;

namespace _7112
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var copy = list.ToArray();
            string[] input;
            while ((input = Console.ReadLine().Split(';'))[0] != "Forge")
                switch (input[0])
                {
                    case "Reverse":
                        if (input[1] == "Sum Left")
                        {
                            var removed = copy.ReversedSumLeft(int.Parse(input[2])).ToList();
                            list = copy.Where(w => list.Contains(w) || removed.Contains(w)).ToList();
                        }
                        break;
                    case "Exclude":
                        if (input[1] == "Sum Left")
                            list = list.SumLeft(int.Parse(input[2])).ToList();
                        else if (input[1] == "Sum Left Right")
                            list = list.SumLeftRight(int.Parse(input[2])).ToList();
                        break;
                }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
