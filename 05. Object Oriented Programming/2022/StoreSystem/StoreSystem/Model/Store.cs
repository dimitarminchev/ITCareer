using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Store 
{
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

	private List<Product> products = null;

	public Store(string name, string type)
	{
		Name = name;
		Type = type;
		Revenue = 0;
		products = new List<Product>();
	}

	public bool ReceiveProduct(Product product)
	{
		if (products.Contains(product)) return false;
		products.Add(product);
		return true;
	}

	public bool SellProduct(string name, int quantity)
	{
		var product = products.Find(x => x.Name == name);

        if (product == null) return false;

		if (product.Quantity < quantity) return false;

		if (product.Quantity == quantity) products.Remove(product);
		else product.Quantity -= quantity;

        Revenue = Revenue + (quantity * product.FinalPrice);

		return true;
    }

	public Product GetProduct(string name)
	{
		return products.Find(x => x.Name == name);
    }

	public override string ToString()
	{
		var sb = new StringBuilder();

		sb.Append($"****Store: {Name} <{Type}>" + Environment.NewLine);
		sb.Append($"****Available products: <{products.Count()}>" + Environment.NewLine);
		foreach (var product in products)
		{
			sb.Append($"****** {product.Name} ({product.Quantity})" + Environment.NewLine);
		}
		sb.Append($"****Revenue: <{Revenue:f2}BGN>");

		return sb.ToString();	
	}
}