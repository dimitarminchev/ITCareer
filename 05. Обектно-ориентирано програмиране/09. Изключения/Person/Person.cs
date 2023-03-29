namespace Person
{
    public class Person
    {
        private string firstname;
        private string lastname;
        private int age;

        public Person(string FirstName = null, string LastName = null, int Age = -1)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0 || value > 120) throw new ArgumentOutOfRangeException("Age mus be between 0 and 120");
                this.age = value;
            }
        }

        public string LastName
        {
            get { return lastname; }
            set
            {
                if (value == null || value.Length == 0) throw new ArgumentNullException("Name Cannot be empty");
                this.lastname = value;
            }
        }

        public string FirstName
        {
            get { return firstname; }
            set
            {
                if (value == null || value.Length == 0) throw new ArgumentNullException("Name Cannot be empty");
                this.firstname = value;
            }
        }
    }
}
