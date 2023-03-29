namespace Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person firstPerson = new Person();
            firstPerson.Name = "George";
            firstPerson.Age = 15;
            firstPerson.IntroduceYourself();

            Person secondPerson = new Person();
            secondPerson.Name = "Peter";
            secondPerson.Age = 23;
            secondPerson.IntroduceYourself();
        }
    }
}