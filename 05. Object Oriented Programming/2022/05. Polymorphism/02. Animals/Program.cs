namespace _02._Animals
{
    public class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat("Tom", "Whiskas");
            Animal dog = new Dog("Jerry", "Meat");

            Console.WriteLine(cat.ExplainMyself());
            Console.WriteLine(dog.ExplainMyself());
        }
    }
}