namespace AnonymousThreat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split().ToList();
            var line = Console.ReadLine().Split();

            while (line[0] != "3:1")
            {
                var command = line[0];

                if (command == "merge")
                {
                    var start = int.Parse(line[1]);
                    var end = int.Parse(line[2]);
                    var denyStart = start < 0;
                    var denyEnd = end >= names.Count;
                    if (denyStart) start = 0;
                    if (denyEnd) end = names.Count - 1;
                    for (int i = start; i < end; end--)
                    {
                        names[i] = names[i] + names[i + 1];
                        names.RemoveAt(i + 1);
                    }
                }

                if (command == "divide")
                {
                    var index = int.Parse(line[1]);
                    var partitions = int.Parse(line[2]);
                    string currentString = names[index];
                    var lenghtOfPartitions = currentString.Length / partitions;
                    var additions = new List<string>(partitions);
                    for (int i = 0; i < partitions - 1; i++)
                    {
                        string currentAdition = currentString.Substring(0, lenghtOfPartitions);
                        additions.Add(currentAdition);
                        currentString = currentString.Substring(lenghtOfPartitions);
                    }
                    additions.Add(currentString);
                    names.RemoveAt(index);
                    names.InsertRange(index, additions);
                }

                line = Console.ReadLine().Split();
            }
            Console.WriteLine(String.Join(" ", names));
        }
    }
}