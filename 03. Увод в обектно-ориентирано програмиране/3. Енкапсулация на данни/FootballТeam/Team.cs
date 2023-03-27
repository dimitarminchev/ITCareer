namespace FootballТeam
{
    class Team
    {
        public Team(string name)
        {
            this.Name = name;
            this.Players = new List<Player>();
        }

        private List<Player> players;
        public List<Player> Players
        {
            get { return players; }
            set { players = value; }
        }

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

        public int Rating()
        {
            double sum = this.Players.Sum(x => x.Rating());
            int count = this.Players.Count();
            return (int)Math.Ceiling(sum / count);
        }
    }
}
