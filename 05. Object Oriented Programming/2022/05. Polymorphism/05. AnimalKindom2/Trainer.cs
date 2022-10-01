/// <summary>
/// Trainer
/// </summary>
public class Trainer
{
    /// <summary>
    /// Animal
    /// </summary>
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

    /// <summary>
    /// Constructor
    /// </summary>
    public Trainer(IAnimal animal)
    {
        Animal = animal;
    }

    /// <summary>
    /// Perform Animal Noise and Trick.
    /// </summary>
    public void Make()
    {
        Animal.Perform();
    }
}