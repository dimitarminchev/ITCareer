public class Citizen : IPerson
{
    public string Name { get; private set; }

    public int Age { get; private set; }

    public Citizen(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
}