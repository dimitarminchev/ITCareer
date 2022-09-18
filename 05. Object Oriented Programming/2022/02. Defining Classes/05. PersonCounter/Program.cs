namespace _05._PersonCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Колекция с хора
            List<Person> persons = new List<Person>();

            // Добавя случаен брой хора към колецията
            Random rand = new Random();
            int random = rand.Next(1000);
            for (int i = 0; i < random; i++)
            {
                var newPerson = new Person(i.ToString(), i);
                persons.Add(newPerson);
            }

            // Колко човека сме добавили в колекцията?
            Console.WriteLine("Persons Conter = {0}", Person.Count);
        }
    }
}