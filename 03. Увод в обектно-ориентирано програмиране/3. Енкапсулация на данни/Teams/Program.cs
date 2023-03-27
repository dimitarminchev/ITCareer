namespace Teams
{
    class Program
    {
        static void Main(string[] args)
        {
            Team team = new Team("Arsenal");

            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                var line = Console.ReadLine().Split().ToArray();
                team.AddPlayer
                (
                    new Person
                    (
                        line[0],
                        line[1],
                        int.Parse(line[2]),
                        float.Parse(line[3])
                    )
                );
                n--;
            }

            Console.WriteLine(team);
        }
    }
}