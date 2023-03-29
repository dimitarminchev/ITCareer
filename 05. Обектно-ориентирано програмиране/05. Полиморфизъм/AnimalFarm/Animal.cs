namespace AnimalFarm
{
    public abstract class Animal
    {
        public string animalName { get; }
        public string animalType { get; }
        public double animalWeight { get; }
        public int foodEaten { get; }

        public virtual void MakeSound()
        {
            // nope
        }

        public void Eat()
        {
            // nope
        }

        public Animal(string animalType, string name, double weight)
        {
            this.animalType = animalType;
            this.animalName = name;
            this.animalWeight = weight;
        }
    }
}