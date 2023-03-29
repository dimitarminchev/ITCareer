namespace AnimalKindom2
{
    public class Trainer
    {
        private IAnimal animal;

        public IAnimal Animal
        {
            get { return animal; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Animal can not be null!");
                }
                animal = value;
                Console.WriteLine("Training: {0}", animal.GetType().ToString());
            }
        }

        public Trainer(IAnimal animal)
        {
            Animal = animal;
        }

        public void Make()
        {
            Animal.Perform();
        }
    }
}