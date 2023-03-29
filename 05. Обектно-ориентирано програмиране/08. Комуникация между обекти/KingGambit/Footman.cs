namespace KingGambit
{
    class Footman
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Footman(string name)
        {
            this.name = name;
        }

        public void Attack(object sender, EventArgs e)
        {
            Console.WriteLine($"Footman {name} is panicking!");
        }
    }
}
