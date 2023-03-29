namespace FoodShortages
{
    class Rebel : IBuyer
    {
        public Rebel(string name, string group,int age)
        {
            this.age = age;
            this.name = name;
            this.group = group;
            this.Food = 0;
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        private string group;

        public string Group
        {
            get { return group; }
            set { group = value; }
        }

        public int Food { get; set; }

        public void BuyFood()
        {
            Food += 5;
        }
    }
}
