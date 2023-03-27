namespace FootballТeam
{
    class Player
    {
        public Player(string name, int du, int sp, int dr, int p, int sh)
        {
            this.Name = name;
            this.Durablility = du;
            this.Sprint = sp;
            this.Dribble = dr;
            this.Passing = p;
            this.Shooting = sh;
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

        public double Rating()
        {
            return (durability + sprint + dribble + passing + shooting) / 5.0;
        }

        private int durability;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public int Durablility
        {
            get { return durability; }
            set
            {
                if (value > 100 || value < 0)
                {
                    Console.WriteLine("Durability should be between 0 and 100");
                }
                else
                {
                    durability = value;
                }
            }
        }
        public int Sprint
        {
            get { return sprint; }
            set
            {
                if (value > 100 || value < 0)
                {
                    Console.WriteLine("Sprint should be between 0 and 100");
                }
                else
                {
                    sprint = value;
                }
            }
        }

        public int Dribble
        {
            get { return dribble; }
            set
            {
                if (value > 100 || value < 0)
                {
                    Console.WriteLine("Dribble should be between 0 and 100");
                }
                else
                {
                    dribble = value;
                }
            }
        }

        public int Passing
        {
            get { return passing; }
            set
            {
                if (value > 100 || value < 0)
                {
                    Console.WriteLine("Passing should be between 0 and 100");
                }
                else
                {
                    passing = value;
                }
            }
        }

        public int Shooting
        {
            get { return shooting; }
            set
            {
                if (value > 100 || value < 0)
                {
                    Console.WriteLine("Shooting should be between 0 and 100");
                }
                else
                {
                    shooting = value;
                }
            }
        }
    }
}
