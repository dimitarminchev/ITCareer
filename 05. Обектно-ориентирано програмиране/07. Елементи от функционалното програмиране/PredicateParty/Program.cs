namespace PredicateParty
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = Console.ReadLine().Split().ToList();
            Action<string> dabul = name => people.Add(name);
            Action<string> remove = name => people.Remove(name);
            Func<string, List<string>> contain = cont => { return people.Where(x => x.Contains(cont)).ToList(); };
            Func<int, List<string>> lenght = len => { return people.Where(x => x.Length == len).ToList(); };
            while (true)
            {
                var cmd = Console.ReadLine().Split().ToArray();
                switch (cmd[0])
                {
                    case "Party!":
                        if (people.Count != 0) Console.WriteLine($"{string.Join(", ", people)} are going to the party!");
                        else Console.WriteLine("Nobody is going to the party!");
                        return;
                    case "Remove":
                        if (cmd[1] == "Length ") lenght(int.Parse(cmd[2])).ForEach(x => remove(x));
                        else contain(cmd[2]).ForEach(x => remove(x));
                        break;
                    case "Double":
                        if (cmd[1] == "Length ")
                            lenght(int.Parse(cmd[2])).ForEach(x => dabul(x));
                        else contain(cmd[2]).ForEach(x => dabul(x));
                        break;
                }
            }
        }
    }
}