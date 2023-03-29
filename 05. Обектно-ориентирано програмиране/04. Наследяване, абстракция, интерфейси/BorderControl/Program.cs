namespace BorderControl
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Robot> robots = new List<Robot>();
            List<Citizen> citizens = new List<Citizen>();
            var line = Console.ReadLine().Split().ToArray();
            while (line.Count() > 1)
            {
                if (line.Count() == 2) robots.Add(new Robot(line[1], line[0]));
                else citizens.Add(new Citizen(line[0], line[2], int.Parse(line[1])));
                line = Console.ReadLine().Split().ToArray();
            }
            string searching = Console.ReadLine();
            Console.WriteLine(string.Join("\n", robots.Select(x => x.ID).ToArray().Where(x => x.Substring(x.Length - 3, 3) == searching).ToArray()));
            Console.WriteLine(string.Join("\n", citizens.Select(x => x.ID).ToArray().Where(x => x.Substring(x.Length - 3, 3) == searching).ToArray()));
        }
    }
}
