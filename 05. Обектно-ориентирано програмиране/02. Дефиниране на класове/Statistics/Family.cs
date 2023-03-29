namespace Statistics
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
            var filer = family.Where(x => x.Age > 30).OrderBy(x => x.Name).ToList();
            filer.ForEach(person => Console.WriteLine($"{person.Name} - {person.Age}"));
        }
    }
}