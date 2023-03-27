namespace OldestFamilyMember
{
    class Family
    {
        private List<Person> people = new List<Person>();

        public List<Person> People
        {
            get { return people; }
            set { people = value; }
        }

        public void AddMember(Person member)
        {
            people.Add(member);
        }

        public Person GetOldestMember()
        {
            return people.OrderByDescending(person => person.Age).FirstOrDefault();
        }
    }
}
