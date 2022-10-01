/// <summary>
/// Базов клас
/// </summary>
public class Animal
{
    /// <summary>
    /// Име
    /// </summary>
    protected string Name { get; set; }

    /// <summary>
    /// Любилма храна
    /// </summary>
    public string FavouriteFood { get; set; }

    /// <summary>
    /// Конструктор
    /// </summary>
    public Animal(string name, string favouriteFood)
    {
        Name = name;
        FavouriteFood = favouriteFood;
    }

    /// <summary>
    /// Презаписване (overriding) 
    /// </summary>
    public virtual string ExplainMyself()
    {
        return $"I am {Name} and my favourite food is {FavouriteFood}";
    }
}