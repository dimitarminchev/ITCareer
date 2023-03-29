namespace AnimalKindom2
{
    public class Cat : IAnimal
    {
        public string MakeNoise()
        {
            return "Meow!";
        }

        public string MakeTrick()
        {
            return "No tricks for you! I'm too lazy!";
        }

        public void Perform()
        {
            Console.WriteLine("Noise: {0}", MakeNoise());
            Console.WriteLine("Trick: {0}", MakeTrick());
        }
    }
}