namespace PersonCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("People = {0}", Person.Count());
            Person Ivan = new Person("Ivan", 12);
            Console.WriteLine("People = {0}", Person.Count());
            Person Peter = new Person("Peter", 18);
            Console.WriteLine("People = {0}", Person.Count());
        }
    }
}