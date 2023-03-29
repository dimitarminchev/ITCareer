using System;
using System.Text;

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

    public double DeliverPrice
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

    public virtual double PercentageMarkup
    {
		get { return percentageMarkup; }
        protected set
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
			return DeliverPrice + (DeliverPrice * PercentageMarkup / 100);
        }
	}

	/// <summary>
	/// Constructor
	/// </summary>
	protected Product(string name, int quantity, double deliverPrice, double percentageMarkup)
	{
		Name = name;
		Quantity = quantity;
		DeliverPrice = deliverPrice;
		PercentageMarkup = percentageMarkup;	
	}

	/// <summary>
	/// ToString
	/// </summary>
	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();

		stringBuilder.AppendLine($"****Product: {Name} <{Quantity}>");
		stringBuilder.AppendLine($"****Deliver Price: {DeliverPrice}");
        stringBuilder.AppendLine($"****Percentage Markup: {PercentageMarkup}");
		stringBuilder.Append($"****Final Price: {FinalPrice}");

        return stringBuilder.ToString();
    }
}