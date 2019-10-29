namespace _3_OldestMembeр
{
    class Person
    {
        // Име
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Възраст
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        // Препокриване на метод
        public override string ToString()
        {
            return $"Name: {this.name}, Age: {this.age}";
        }
    }
}
