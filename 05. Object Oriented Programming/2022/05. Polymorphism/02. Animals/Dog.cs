/// <summary>
/// Производен / Дъщерен / Подклас
/// </summary>
public class Dog : Animal
{
    /// <summary>
    /// Конструктор
    /// </summary>
    public Dog(string name, string favouriteFood) : base(name, favouriteFood)
    {
        // nope
    }

    /// <summary>
    /// Презаписване (overriding) 
    /// </summary>
    public override string ExplainMyself()
    {
        return base.ExplainMyself() + Environment.NewLine + "DJAAF";
    }
}