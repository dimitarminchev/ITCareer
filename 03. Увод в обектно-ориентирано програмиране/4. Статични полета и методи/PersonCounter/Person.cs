namespace PersonCounter
{
    class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name must be not null or empty.");
                }
                name = value;
            }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age must be positive value.");
                }
                age = value;
            }
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            counter = counter + 1;
        }

        private static int counter = 0;

        public static int Count()
        {
            return counter;
        }
    }
}
