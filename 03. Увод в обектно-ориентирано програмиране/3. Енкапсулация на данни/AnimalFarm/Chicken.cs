namespace AnimalFarm
{
    class Chicken
    {
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

        public Chicken(string name, int age)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name cannot be empty.");
            }

            this.name = name;
            this.age = age;
        }

        public string CalculateProductPerDay()
        {
            if (this.age < 0 || this.age > 15)
            {
                throw new ArgumentException("Age should be between 0 and 15.");
            }

            return $"Chicken {this.name}(age {this.age}) can produce 1 eggs per day.";
        }
    }
}
