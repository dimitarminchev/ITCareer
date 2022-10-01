/// <summary>
/// Производен / Дъщерен / Подклас
/// </summary>
public class Cat : Animal
{
	/// <summary>
	/// Конструктор
	/// </summary>
	public Cat(string name, string favouriteFood) : base(name, favouriteFood)
	{
		// nope
	}

    /// <summary>
    /// Презаписване (overriding) 
    /// </summary>
    public override string ExplainMyself()
    {
        return base.ExplainMyself() + Environment.NewLine + "MEEOW";
    }
}