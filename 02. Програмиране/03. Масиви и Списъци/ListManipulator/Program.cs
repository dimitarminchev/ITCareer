namespace ListManipulator
{
    internal class Program
    {
        public static List<T> ShiftLeft<T>(this List<T> list, int shiftBy)
        {
            if (list.Count <= shiftBy)
            {
                return list;
            }

            var result = list.GetRange(shiftBy, list.Count - shiftBy);
            result.AddRange(list.GetRange(0, shiftBy));
            return result;
        }

        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] command;
            while (true)
            {
                command = Console.ReadLine().Split().ToArray();
                switch (command[0])
                {
                    case "add":
                        numbers.Insert(int.Parse(command[1]), int.Parse(command[2]));
                        break;

                    case "addMany":
                        var items = command.Skip(2).Select(int.Parse).ToList();
                        numbers.InsertRange(int.Parse(command[1]), items);
                        break;

                    case "contains":
                        var index = numbers.Find(number => number == int.Parse(command[1]));
                        if (!numbers.Contains(int.Parse(command[1]))) index = -1;
                        Console.WriteLine(index);
                        break;

                    case "remove":
                        numbers.RemoveAt(int.Parse(command[1]));
                        break;

                    case "shift":
                        numbers = ShiftLeft(numbers, int.Parse(command[1]));
                        break;

                    case "sumPairs":
                        List<int> sums = new List<int>();
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            var pair = numbers.Skip(i * 2).Take(2);
                            if (pair.Count() == 0) break;
                            sums.Add(pair.Sum());
                        }
                        numbers = sums;
                        break;

                    case "print":
                        Console.WriteLine(string.Join(" ", numbers));
                        return;
                }
            }
        }
    }
}