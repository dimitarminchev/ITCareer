namespace Statistics
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
            members = members.Where(x => x.Age > 30).OrderBy(y => y.Name).ToList();

            foreach (Person member in members)
            {
                Console.WriteLine($"{member.Name} - {member.Age}");
            }
        }
    }
}
