using System;

public class Drink : Product
{
    private double percentageMarkup;

    protected override double PercentageMarkup
    {
        get { return percentageMarkup; }
        set
        {
            if (value > 200)
            {
                throw new ArgumentException("Drink percentage markup cannot be above 200%!");
            }
            percentageMarkup = value;
        }
    }

    public Drink(string name, int quantity, double deliverPrice, double percentageMarkup) : base(name, quantity, deliverPrice, percentageMarkup)
    {
        this.PercentageMarkup = percentageMarkup;
    }
}