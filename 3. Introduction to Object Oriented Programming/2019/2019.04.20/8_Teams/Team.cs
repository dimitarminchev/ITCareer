using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Teams
{
    class Team
    {
        // Полета
        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;

        // Конструктор
        public Team(string name)
        {
            this.name = name;
            this.firstTeam = new List<Person>();
            this.reserveTeam = new List<Person>();
        }

        // Първи отбор
        public IReadOnlyCollection<Person> FirstTeam
        {
            get { return this.firstTeam.AsReadOnly(); }
        }

        // Резервен отбор
        public IReadOnlyCollection<Person> ReserveTeam
        {
            get { return this.reserveTeam.AsReadOnly(); }
        }

        // Добавяне на играч
        public void AddPlayer(Person player)
        {
            if (player.Age < 40)
            {
                firstTeam.Add(player);
            }
            else
            {
                reserveTeam.Add(player);
            }
        }

        // Препокриване/Пренаписване 
        public override string ToString()
        {
            return "First team have " + this.FirstTeam.Count + " players\n"
                 + "Reserve team have " + this.ReserveTeam.Count + " players";
        }
    }
}
