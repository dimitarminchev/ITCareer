namespace CustomListEnumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomList<string> list = new CustomList<string>();

            var cmd = Console.ReadLine().Split().ToArray();
            while (cmd[0] != "END")
            {
                switch (cmd[0])
                {
                    case "Add": list.Add(cmd[1]); break;
                    case "Remove":
                        Console.WriteLine(list.Remove(int.Parse(cmd[1])));
                        break;
                    case "Contains":
                        Console.WriteLine(list.Contains(cmd[1]));
                        break;
                    case "Swap":
                        list.Swap(int.Parse(cmd[1]), int.Parse(cmd[2]));
                        break;
                    case "Greater":
                        Console.WriteLine(list.CountGreaterThan(cmd[1]));
                        break;
                    case "Max":
                        Console.WriteLine(list.Max());
                        break;
                    case "Min":
                        Console.WriteLine(list.Min());
                        break;
                    case "Print":
                        list.Print();
                        break;
                    case "Sort":
                        list.Sort();
                        break;
                }
                cmd = Console.ReadLine().Split().ToArray();
            }
        }
    }
}