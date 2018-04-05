using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App8
{
    class Team
    {
        // Конструктор
        public Team(string name)
        {
            this.Name = name;
            this.Players = new List<Player>();
        }

        // Играчи
        private List<Player> players;
        public List<Player> Players
        {
            get { return players;  }
            set { players = value; }
        }

        // Име
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length == 0 || String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("A name should not be empty");
                }
                else
                {
                    name = value;
                }
            }
        }

        // Рейтинг
        public int Rating()
        {
            double sum = this.Players.Sum(x => x.Rating());
            int count = this.Players.Count();
            return (int)Math.Ceiling(sum / count);
        }
    }
}
