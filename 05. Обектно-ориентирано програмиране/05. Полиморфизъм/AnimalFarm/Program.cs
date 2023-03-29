namespace AnimalFarm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var line = System.Console.ReadLine().Split(' ').ToArray(); ;
            Animal animal = new Tiger("", "", 0, ""); Food food = new Meat(0);
            for (int i = 1; line[0] != "End"; i++)
            {
                if (i % 2 != 0)
                    switch (line[0])
                    {
                        case "Cat": animal = new Cat(line[0], line[1], double.Parse(line[2]), line[3], line[4]); break;
                        case "Mouse": animal = new Mouse(line[0], line[1], double.Parse(line[2]), line[3]); break;
                        case "Tiger": animal = new Tiger(line[0], line[1], double.Parse(line[2]), line[3]); break;
                        case "Zebra": animal = new Zebra(line[0], line[1], double.Parse(line[2]), line[3]); break;
                    }
                else
                {
                    switch (line[0])
                    {
                        case "Vegetable": food = new Vegetable(int.Parse(line[1])); break;
                        case "Meat": food = new Meat(int.Parse(line[1])); break;
                    }
                    switch (animal.animalType)
                    {
                        case "Cat":
                            animal.MakeSound();
                            Console.WriteLine(animal.ToString() + "," + food.quantity);
                            break;
                        case "Mouse":
                            animal.MakeSound();
                            if (line[0] == "Meat")
                                Console.WriteLine($"{animal.animalType}s are not eating that type of food!");
                            Console.WriteLine(animal.ToString() + "," + food.quantity);
                            break;
                        case "Tiger":
                            animal.MakeSound();
                            if (line[0] == "Vegetable")
                                Console.WriteLine($"{animal.animalType}s are not eating that type of food!");
                            Console.WriteLine(animal.ToString() + "," + food.quantity);
                            break;
                        case "Zebra":
                            animal.MakeSound();
                            if (line[0] == "Meat")
                                Console.WriteLine($"{animal.animalType}s are not eating that type of food!");
                            Console.WriteLine(animal.ToString() + "," + food.quantity);
                            break;
                    }
                }
                line = System.Console.ReadLine().Split(' ').ToArray();
            }
        }
    }
}