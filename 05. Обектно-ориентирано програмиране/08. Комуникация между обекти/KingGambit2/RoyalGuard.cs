namespace KingGambit2
{
    class RoyalGuard : EventArgs
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

        public RoyalGuard(string name)
        {
            this.name = name;
            health = 3;
        }
        public void Attack(object sender, EventArgs e)
        {
            if (this.health == 0)
            {
                return;
            }
            health--;
            Console.WriteLine($"Royal Guard {name} is defending!");
            if (health == 0) Death(this,e);
        }
        public void Death(object sender, EventArgs e)
        {
            if (this.health == 0)
            {
                return;
            }
            health--;
            Console.WriteLine($"Royal Guard {name} is defending!");
        }
    }
}
