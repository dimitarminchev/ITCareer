using System;
using System.Collections.Generic;
using System.Text;

public class PhysicalProduct : Product
{
    private double quantity;

    public double Quantity
    {
        get
        {
            return quantity;
        }
        set
        {
            quantity = value;
        }
    }

    public PhysicalProduct(string title, double price, double quantity)
        : base(title, price)
    {
        Quantity = quantity;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"Title: {Title}");
        sb.AppendLine($"Price: {Price:F2} EUR");
        sb.AppendLine($"Quantity: {Quantity:F2}");

        return sb.ToString();
    }
}


