namespace AnimalKindom2
{
    public class Dog : IAnimal
    {
        public string MakeNoise()
        {
            return "Woof!";
        }

        public string MakeTrick()
        {
            return "Hold my bone, human!";
        }

        public void Perform()
        {
            Console.WriteLine("Noise: {0}", MakeNoise());
            Console.WriteLine("Trick: {0}", MakeTrick());
        }
    }
}