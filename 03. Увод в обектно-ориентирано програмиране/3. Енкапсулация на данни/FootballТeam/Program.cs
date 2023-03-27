using System.Numerics;

namespace FootballТeam
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Team> team = new List<Team>();

            string line = String.Empty;
            while (true)
            {
                line = Console.ReadLine();
                if (line == "END") break;
                var cmd = line.Split(';');
                switch (cmd[0])
                {
                    case "Team":
                        {
                            team.Add(new Team(cmd[1]));
                            break;
                        }
                    case "Add":
                        {
                            var tm = team.Where(x => x.Name == cmd[1]).First();
                            tm.Players.Add(new Player
                            (
                                 cmd[2],
                                 int.Parse(cmd[3]),
                                 int.Parse(cmd[4]),
                                 int.Parse(cmd[5]),
                                 int.Parse(cmd[6]),
                                 int.Parse(cmd[7])
                            ));
                            break;
                        }
                    case "Remove":
                        {
                            var tm = team.Where(x => x.Name == cmd[1]).First();
                            var pl = tm.Players.Where(x => x.Name == cmd[2]).First();
                            tm.Players.Remove(pl);
                            break;
                        }
                    case "Rating":
                        {
                            var tm = team.Where(x => x.Name == cmd[1]).Take(1).First();
                            Console.WriteLine("{0} - {1}", tm.Name, tm.Rating());
                            break;
                        }
                }
            }
        }
    }
}