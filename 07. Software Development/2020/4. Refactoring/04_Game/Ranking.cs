namespace Game
{
    public class Ranking
    {
        private string name;
        private int points;
        public string Player
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Points
        {
            get
            {
                return points;
            }

            set
            {
                points = value;
            }
        }

        public Ranking()
        {
            this.Player = "";
            this.Points = 0;
        }

        public Ranking(string name, int points)
        {
            this.Player = name;
            this.Points = points;
        }
    }
}