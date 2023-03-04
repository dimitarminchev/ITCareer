namespace Minesweeper
{
    public class Ratings
    {
        private string name;

        public string Name
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

        private int points;

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

        public Ratings(string name, int points)
        {
            this.name = name;
            this.points = points;
        }

        public Ratings() : this(string.Empty, 0)
        {
            // empty
        }
    }
}
