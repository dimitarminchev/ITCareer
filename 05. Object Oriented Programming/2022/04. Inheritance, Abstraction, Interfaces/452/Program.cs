using System.Reflection;

namespace _452
{
    internal class Program
    {
        // 452
        static void Main(string[] args)
        {
            Type identifiableInterface = typeof(Citizen).GetInterface("IIdentifiable");

            Type birthableInterface = typeof(Citizen).GetInterface("IBirthable");

            PropertyInfo[] properties = identifiableInterface.GetProperties();

            Console.WriteLine(properties.Length);

            Console.WriteLine(properties[0].PropertyType.Name);

            properties = birthableInterface.GetProperties();

            Console.WriteLine(properties.Length);

            Console.WriteLine(properties[0].PropertyType.Name);

            string name = Console.ReadLine();

            int age = int.Parse(Console.ReadLine());

            string id = Console.ReadLine();

            string birthdate = Console.ReadLine();

            IIdentifiable identifiable = new Citizen(name, age, id, birthdate);

            IBirthable birthable = new Citizen(name, age, id, birthdate);
        }
    }
}