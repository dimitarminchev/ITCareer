namespace AnimalFarm
{
    public abstract class Mammal : Animal
    {
        public string livingRegion { get; }

        public Mammal(string animalType, string name, double weight, string livingRegion) : base(animalType, name, weight)
        {
            this.livingRegion = livingRegion;
        }
    }
}