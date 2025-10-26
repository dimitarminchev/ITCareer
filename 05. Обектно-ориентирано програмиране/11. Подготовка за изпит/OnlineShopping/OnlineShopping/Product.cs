using System;
using System.Collections.Generic;
using System.Text;

public abstract class Product
{
    private string title;

    public string Title
    {
        get
        {
            return title;
        }
        set
        {
            if (value.Length < 2 || value.Length > 100)
            {
                throw new ArgumentException("Title should be between 2 and 100 characters!");
            }
            title = value;
        }
    }

    private double price;

    public double Price
    {
        get
        {
            return price;
        }
        set
        {
            if (value < 0)
            { 
               throw new ArgumentException("Price should be positive!");
            }
            price = value;
        }
    }

    public Product(string title, double price)
    {
        Price = price;
        Title = title;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"Title: {Title}");
        sb.AppendLine($"Price: {Price:F2} EUR");

        return sb.ToString();
    }
}