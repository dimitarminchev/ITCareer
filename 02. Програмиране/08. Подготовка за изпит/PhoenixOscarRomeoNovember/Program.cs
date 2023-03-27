namespace PhoenixOscarRomeoNovember
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<String, List<String>>();

            string line = Console.ReadLine();
            while (line != "Blaze it!")
            {
                var Parts = line.Split('>');
                var Creature = Parts[0].Trim('-').Trim(' ');
                var SquadMate = Parts[1].Trim(' ');
                if (Creature != SquadMate)
                {
                    if (!dict.ContainsKey(Creature))
                    {
                        dict.Add(Creature, new List<String>() { SquadMate });
                    }
                    else if (!dict[Creature].Contains(SquadMate))
                    {
                        dict[Creature].Add(SquadMate);
                    }
                }
                line = Console.ReadLine();
            }

            var nope = new Dictionary<String, List<String>>();
            foreach (var creature in dict)
            {
                var list = new List<String>();
                foreach (var mate in creature.Value)
                {
                    if (dict.ContainsKey(mate))
                    {
                        if (dict[mate].Contains(creature.Key))
                        {
                            continue;
                        }
                    }
                    list.Add(mate);
                }
                nope.Add(creature.Key, list);
            }

            var sorted = nope.OrderByDescending(x => x.Value.Count);
            foreach (var item in sorted)
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Value.Count);
            }
        }
    }
}