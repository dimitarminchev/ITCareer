namespace KingGambit2
{
    class Footman
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int health;

        public int Health
        {
            get { return health; }
            set { health = value; }
        }
        public Footman(string name)
        {
            this.name = name;
            health = 2;
        }

        public void Attack(object sender, EventArgs e)
        {
            if (this.health == 0)
            {
                return;
            }
            health--;
            Console.WriteLine($"Footman {name} is panicking!");
        }
        public void Death(object sender, EventArgs e)
        {
            if (this.health == 0)
            {
                return;
            }
        }
    }
}
