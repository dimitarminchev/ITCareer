namespace _01._Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Създаване на обект firstPerson инстанция на класа Person
            Person firstPerson = new Person();
            firstPerson.Name = "George";
            firstPerson.Age = 15;
            firstPerson.IntroduceYourself();

            // Създаване на обект secondPerson инстанция на класа Person
            Person secondPerson = new Person();
            secondPerson.Name = "Peter";
            secondPerson.Age = 23;
            secondPerson.IntroduceYourself();
        }
    }
}