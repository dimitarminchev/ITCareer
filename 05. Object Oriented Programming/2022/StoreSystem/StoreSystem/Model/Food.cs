using System;

public class Food : Product
{
    private double percentageMarkup;

    protected override double PercentageMarkup
    {
        get { return percentageMarkup; }
        set
        {
            if (value > 100)
            {
                throw new ArgumentException("Food percentage markup cannot be above 100%!");
            }
            percentageMarkup = value;
        }
    }

    public Food(string name, int quantity, float deliverPrice, float percentageMarkup) : base(name, quantity, deliverPrice, percentageMarkup)
    {
        this.PercentageMarkup = percentageMarkup;
    }
}