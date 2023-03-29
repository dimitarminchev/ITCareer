namespace InfernoIII
{
    class Program
    {
        static void Main(string[] args)
        {
            var stones = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int initialCount = stones.Count();
            var lastExcluded = new List<int>();
            Action<int> add = (s) =>
            {
                stones.AddRange(lastExcluded); lastExcluded = new List<int>();
            };
            Action<int> remove = name =>
            {
                stones.Remove(name); lastExcluded.Add(name);
            };
            Func<int, List<int>> containLR = s =>
            {
                List<int> result = new List<int>();
                if (s == 3) result.Add(1);
                else if (s == initialCount * 2 - 1) result.Add(initialCount);
                result.AddRange(stones.Where(x => 3 * x == s).ToList());
                return result;
            };
            Func<int, List<int>> containL = s =>
            {
                List<int> result = new List<int>();
                if (s == 1) result.Add(1);
                result.AddRange(stones.Where(x => 2 * x - 1 == s).ToList());
                return result;
            };
            Func<int, List<int>> containR = s =>
            {
                List<int> result = new List<int>();
                if (s == initialCount) result.Add(initialCount);
                result.AddRange(stones.Where(x => 2 * x + 1 == s).ToList());
                return result;
            };
            while (true)
            {
                var cmd = Console.ReadLine().Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                switch (cmd[0])
                {
                    case "Reverse":
                        add(0);
                        break;
                    case "Exclude":
                        if (cmd[1] == "Sum Left Right") containLR(int.Parse(cmd[2])).ForEach(x => remove(x));
                        else if (cmd[1] == "Sum Left") containL(int.Parse(cmd[2])).ForEach(x => remove(x));
                        else containR(int.Parse(cmd[2])).ForEach(x => remove(x));
                        break;
                    case "Forge":
                        Console.WriteLine(string.Join(" ", stones.OrderBy(x => x).Distinct()));
                        return;
                }
            }
        }
    }
}