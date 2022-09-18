namespace _06._MemoryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Създаване на обект инстанция на класа 
            Animals animals = new Animals();

            // Добавяне на животни
            animals.Add(new Animal("Turtle", 200));
            animals.Add(new Animal("Snake", 7));
            animals.Add(new Animal("Cat", 5));
            animals.Add(new Animal("Dog", 12));

            // Брой на животнитни
            Console.WriteLine("Animals Count = {0}", Animals.Count);

            // Унишожаване на обекта инстаниця на класа
            animals.Dispose();

            // v2
            //using (var animals = new Animals())
            //{
            //    animals.Add(new Animal("Turtle", 200));
            //    animals.Add(new Animal("Snake", 7));
            //    animals.Add(new Animal("Cat", 5));
            //    animals.Add(new Animal("Dog", 12));
            //    Console.WriteLine("Animals Count = {0}", Animals.Count);
            //}
        }
    }
}