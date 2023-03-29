namespace MultipleInterfaces
{
    public class Citizen : IPerson, IBirthable, IIdentifiable
    {
        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Birthdate { get; private set; }

        public string Id { get; private set; }

        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
        }
    }
}
