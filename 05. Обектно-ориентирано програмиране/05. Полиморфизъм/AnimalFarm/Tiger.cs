namespace AnimalFarm
{
    public class Tiger : Felime
    {
        public Tiger(string animalType, string name, double weight, string livingRegion) : base(animalType, name, weight, livingRegion)
        {
            // nope
        }

        public override void MakeSound()
        {
            Console.WriteLine("ROAAR!!!");
        }

        public override string ToString()
        {
            return $"{animalType}[{animalName},{animalWeight},{livingRegion}]";
        }
    }
}