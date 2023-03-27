namespace AnimalFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Chicken chicken = new Chicken(name, age);

            Console.WriteLine(chicken.CalculateProductPerDay());
        }
    }
}