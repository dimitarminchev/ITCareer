namespace PredicatePartyFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = Console.ReadLine().Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var invited = new List<string>();
            Action<string> add = name => invited.Add(name);
            Action<string> remove = name => invited.Remove(name);
            Func<string, List<string>> contain = cont => { return people.Where(x => x.Contains(cont)).ToList(); };
            Func<int, List<string>> lenght = len => { return people.Where(x => x.Length == len).ToList(); };
            while (true)
            {
                var cmd = Console.ReadLine().Split().ToArray();
                switch (cmd[0])
                {
                    case "Add filter":
                        if (cmd[1] == "Length ") lenght(int.Parse(cmd[2])).ForEach(x => add(x));
                        else contain(cmd[2]).ForEach(x => add(x));
                        break;
                    case "Remove filter":
                        if (cmd[1] == "Length ") lenght(int.Parse(cmd[2])).ForEach(x => remove(x));
                        else contain(cmd[2]).ForEach(x => remove(x));
                        break;
                    case "Print":
                        Console.WriteLine(string.Join(" ", invited));
                        return;
                }
            }
        }
    }
}