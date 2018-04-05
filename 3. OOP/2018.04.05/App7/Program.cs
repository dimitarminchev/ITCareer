using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App7
{
    class Program
    {
        static void Main(string[] args)
        {
            var team = new Team("Kremikovci");
            var lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                var playersInfo = Console.ReadLine().Split();
                var person = new Person(playersInfo[0], playersInfo[1], int.Parse(playersInfo[2]));
                team.AddPlayer(person);
            }
            Console.WriteLine("First team have {0} players", team.FirstTeam.Count());
            Console.WriteLine("First team have {0} players", team.ReserveTeam.Count());

        }
    }
}
