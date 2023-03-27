namespace EmployeeData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string Years = Console.ReadLine();
            string gender = Console.ReadLine();
            string personalID = Console.ReadLine();
            string employeeNumber = Console.ReadLine();

            Console.WriteLine($"First name : {firstName}");
            Console.WriteLine($"Last name : {lastName}");
            Console.WriteLine($"Age : {Years}");
 
            if (gender == "f")
            {
                Console.WriteLine($"Gender : f ");
            }
            else if (gender == "m")
            {
                Console.WriteLine($"Gender : m ");
            }

            Console.WriteLine($"Personal ID : {personalID}");
            Console.WriteLine($"Unique Employee number : {employeeNumber}");
        }
    }
}