using System;

public class Food : Product
{
    /// <summary>
    /// Constructor
    /// </summary>
    public Food(string name, int quantity, double deliverPrice, double percentageMarkup) : 
        base(name, quantity, deliverPrice, percentageMarkup)
    {
        // nope
    }

    /// <summary>
    /// Percent
    /// </summary>
    public override double PercentageMarkup
    {
        get { return base.PercentageMarkup; }
        protected set
        {
            if (value > 100)
            {
                throw new ArgumentException("Food percentage markup cannot be above 100%!");
            }
            base.PercentageMarkup = value;
        }
    }
}