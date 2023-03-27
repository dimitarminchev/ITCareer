namespace PersonClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person firstPerson = new Person();
            firstPerson.Name = "Ivan";
            firstPerson.Age = 12;
            firstPerson.IntroduceYourself();
        }
    }
}