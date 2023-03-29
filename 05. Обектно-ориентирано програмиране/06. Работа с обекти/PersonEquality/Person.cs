namespace PersonEquality
{
    public class Person : IComparable
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

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override bool Equals(object obj)
        {
            Person person = (Person)obj;
            if (this.Age == person.age && this.name == person.name)
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return this.name.GetHashCode() + age;
        }

        public int CompareTo(object obj)
        {
            Person person = (Person)obj;
            if (this.Age == person.age && this.name == person.name)
            {
                return 0;
            }
            return 1;
        }
    }
}