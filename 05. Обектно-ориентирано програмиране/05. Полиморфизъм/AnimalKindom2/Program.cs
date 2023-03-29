namespace AnimalKindom2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trainer trainer = new Trainer(new Cat());
            trainer.Make();

            trainer.Animal = new Dog();
            trainer.Make();
        }
    }
}