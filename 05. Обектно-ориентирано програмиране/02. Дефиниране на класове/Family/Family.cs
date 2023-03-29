namespace Family
{
    public class Family
    {
        private List<Person> family = new List<Person>();

        public void Add(string name, int age)
        {
            family.Add(new Person { Name = name, Age = age });
        }

        public void Print()
        {
            family.ForEach(person => Console.WriteLine($"{person.Name} {person.Age}"));
        }
    }
}