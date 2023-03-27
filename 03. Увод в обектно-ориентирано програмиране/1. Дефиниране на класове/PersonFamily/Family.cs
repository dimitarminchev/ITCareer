namespace PersonFamily
{
    class Family
    {
        private List<Person> members = new List<Person>();

        public void AddMember(Person member)
        {
            members.Add(member);
        }

        public void Print()
        {
            foreach (Person member in members)
            {
                Console.WriteLine($"{member.Name} - {member.Age}");
            }
        }
    }
}
