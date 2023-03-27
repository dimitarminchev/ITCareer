namespace VariableList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] command;
            while (true)
            {
                command = Console.ReadLine().Split().ToArray();
                switch (command[0])
                {
                    case "Insert":
                        numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;

                    case "Delete":
                        numbers.RemoveAll(number => number == int.Parse(command[1]));
                        break;

                    case "Odd":
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 != 0)));
                        return;

                    case "Even":
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 0)));
                        return;

                }
            }
        }
    }
}