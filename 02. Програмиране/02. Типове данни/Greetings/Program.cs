namespace Greetings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string surName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            
            object hello = name + " " + surName;
            
            Console.WriteLine("Hello {0}. You are {1} years old.", hello, age);
        }
    }
}