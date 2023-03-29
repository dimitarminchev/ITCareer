namespace AnimalFarm
{
    public class Mouse : Mammal
    {
        public Mouse(string animalType, string name, double weight, string livingRegion) : base(animalType, name, weight, livingRegion)
        {
            // nope
        }

        public override void MakeSound()
        {
            Console.WriteLine("SQUEEEAAAK!");
        }

        public override string ToString()
        {
            return $"{animalType}[{animalName},{animalWeight},{livingRegion}]";
        }
    }
}