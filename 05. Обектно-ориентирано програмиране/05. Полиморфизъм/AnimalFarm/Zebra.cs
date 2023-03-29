namespace AnimalFarm
{
    public class Zebra : Mammal
    {
        public Zebra(string animalType, string name, double weight, string livingRegion) : base(animalType, name, weight, livingRegion)
        {
            // nope
        }

        public override void MakeSound()
        {
            Console.WriteLine("Zs");
        }

        public override string ToString()
        {
            return $"{animalType}[{animalName},{animalWeight},{livingRegion}]";
        }
    }
}