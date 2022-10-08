namespace _02_Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person pesho = new Person("Pesho", "Peshev", 24);

                // Person noFirstName = new Person(string.Empty, "Petrov", 23);

                // Person noLastName = new Person("Peter", string.Empty, 22);

                Person negativeAge = new Person("Ivan", "Ivanov", -42);

                Person iskren = new Person("Iskren", "Petrov", 121);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            finally
            {
                Console.WriteLine("Job Done!");
            }
        }
    }
}