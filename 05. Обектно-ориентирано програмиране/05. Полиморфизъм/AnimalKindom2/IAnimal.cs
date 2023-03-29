namespace AnimalKindom2
{
    public interface IAnimal : IMakeNoise, IMakeTrick
    {
        void Perform();
    }
}