namespace KingGambit2
{
    class King
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public King(string name)
        {
            this.name = name;
        }
        public void Attack(object sender, EventArgs e)
        {
            Console.WriteLine($"King {name} is under attack!");
        }

        public event EventHandler AttackedKing;

        public void UnderAttack(EventArgs e)
        {
            AttackedKing(this, e);
        }
    }
}
