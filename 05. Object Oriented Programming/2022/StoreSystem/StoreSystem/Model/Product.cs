using System;

public abstract class Product 
{
	private string name;

	public string Name
	{
		get { return name; }
        private set
        {
			if (string.IsNullOrEmpty(value))
			{
				throw new ArgumentException("Product name must not be null or empty!");
			}
			name = value; 
		}
	}

	private int quantity;

    public int Quantity
    {
		get { return quantity; }
        set
        {
			if (value <= 0)
			{
				throw new ArgumentException("Quantity cannot be less or equal to 0!");
            }
			quantity = value; 
		}
	}

	private double deliverPrice;

    protected double DeliverPrice
    {
		get { return deliverPrice; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Deliver price cannot be less or equal to 0!");
            }
            deliverPrice = value; 
		}
	}

	private double percentageMarkup;

    protected virtual double PercentageMarkup
    {
		get { return percentageMarkup; }
		set 
		{
            if (value <= 0)
            {
                throw new ArgumentException("Percentage markup cannot be less or equal to 0!");
            }
            percentageMarkup = value; 
		}
	}

    public double FinalPrice
    {
		get 
		{ 
			return deliverPrice + ((deliverPrice * percentageMarkup) / 100.0);
        }
	}

	protected Product(string name, int quantity, double deliverPrice, double percentageMarkup)
	{
		Name = name;
		Quantity = quantity;
		DeliverPrice = deliverPrice;
		PercentageMarkup = percentageMarkup;	
	}

	public override string ToString()
	{
		return $"****Product: {Name} <{Quantity}>\n****Deliver Price: {DeliverPrice}\n****Percentage Markup: {PercentageMarkup}\n****Final Price: {FinalPrice}\n";
	}
}