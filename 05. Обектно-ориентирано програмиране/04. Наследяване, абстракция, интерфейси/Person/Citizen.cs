namespace Person
{
    public class Citizen : IPerson
    {
        public string Name { get; private set; }

        public int Age { get; private set; }

        public Citizen(string name, int age)
        {
            Name = name;
            Age = age;  
        }
    }
}