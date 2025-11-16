using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Store 
{
    private readonly List<Product> products = null;

    private string name;

	public string Name
    {
		get { return name; }
		private set 
		{
			if (string.IsNullOrEmpty(value))
			{
				throw new ArgumentException("Store name must not be null or empty!");
			}
			name = value; 
		}
	}

	private string type;

	public string Type
    {
		get { return type; }
		private set 
		{
			if (string.IsNullOrEmpty(value))
			{
				throw new ArgumentException("Store type must not be null or empty!");
			}
			type = value; 
		}
	}

	private double revenue;

	public double Revenue
    {
		get { return revenue; }
		private set { revenue = value; }
	}

    /// <summary>
    /// Constructor
    /// </summary>
	public Store(string name, string type)
	{
		Name = name;
		Type = type;
		Revenue = 0;
		products = new List<Product>();
	}

    /// <summary>
    /// ReceiveProduct
    /// </summary>
    public bool ReceiveProduct(Product product)
	{
        if (products.Any(x => x.Name.Equals(product.Name)))
        {
            return false;
        }

        products.Add(product);

        return true;
    }

    /// <summary>
    /// SellProduct
    /// </summary>
    public bool SellProduct(string name, int quantity)
	{
        if (!products.Any(x => x.Name.Equals(name)))
        {
            return false;
        }

        Product product = products.First(x => x.Name.Equals(name));

        if (quantity > product.Quantity)
        {
            return false;
        }

        if (product.Quantity == quantity)
        {
            products.Remove(product);
        }
        else
        {
            product.Quantity -= quantity;
        }

        Revenue += quantity * product.FinalPrice;

        return true;
    }

    /// <summary>
    /// GetProduct
    /// </summary>
    public Product GetProduct(string name)
	{
		return products.FirstOrDefault(x => x.Name.Equals(name));
    }

    /// <summary>
    /// ToString
    /// </summary>
    public override string ToString()
	{
		var stringBuilder = new StringBuilder();

        stringBuilder.AppendLine($"****Store: {Name} <{Type}>");
        stringBuilder.AppendLine($"****Available products: <{products.Count()}>");
        products.ForEach(x => stringBuilder.AppendLine($"****** {x.Name} ({x.Quantity})"));
        stringBuilder.Append($"****Revenue: <{Revenue:f2}BGN>");

		return stringBuilder.ToString();	
	}
}