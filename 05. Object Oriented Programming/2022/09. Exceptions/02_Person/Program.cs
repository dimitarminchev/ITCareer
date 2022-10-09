namespace _02_Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // 1. No exception
                Person pesho = new Person("Pesho", "Peshev", 24);

                // 2. ArgumentNullException
                Person noFirstName = new Person(string.Empty, "Petrov", 23);
                Person noLastName = new Person("Peter", string.Empty, 22);

                // 3. ArgumentOutOfRangeException
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