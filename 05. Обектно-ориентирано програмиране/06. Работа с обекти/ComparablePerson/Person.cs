namespace ComparablePerson
{
    public class Person : IComparable<Person>
    {
        private string name;

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        private int age;

        public int Age
        {
            get { return age; }
            private set { age = value; }
        }

        private string city;

        public string City
        {
            get { return city; }
            private set { city = value; }
        }

        public Person(string name, int age, string city)
        {
            this.name = name;
            this.age = age;
            this.city = city;
        }

        public int CompareTo(Person other)
        {
            int compared = this.Name.CompareTo(other.Name);
            if (compared == 0)
            {
                compared = this.Age.CompareTo(other.Age);
            }
            if (compared == 0)
            {
                compared = this.City.CompareTo(other.City);
            }
            return compared;
        }
    }
}
