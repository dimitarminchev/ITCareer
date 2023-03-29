namespace KingGambit
{
    class RoyalGuard:EventArgs
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public RoyalGuard(string name)
        {
            this.name = name;
        }
        public void Attack(object sender, EventArgs e)
        {
            Console.WriteLine($"Royal Guard {name} is defending!");
        }
    }
}
