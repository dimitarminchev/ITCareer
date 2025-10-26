using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Category
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
            if (value.Length < 3 || value.Length > 50)
            {
                throw new ArgumentException("Category title should be between 3 and 50 characters!");
            }
            title = value;
        }
    }

    private List<Product> products;

    public Category(string title)
    {
        Title = title;
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double MinPrice()
    {
        return products.Min(p => p.Price);
    }

    public List<Product> GetProductsInRange(double from, double to)
    {
        return products
               .Where(p => p.Price >= from && p.Price <= to)
               .OrderBy(t => t.Title)
               .ToList();
    }

    public List<Product> GetProductsExpensiveToCheap()
    {
        return products
               .OrderByDescending(p => p.Price)
               .ToList();
    }

    public List<Product> GetProductsCheapToExpensive()
    {
        return products
               .OrderBy(p => p.Price)
               .ToList();
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Category: {Title}");
        sb.AppendLine($"Total Products: {products.Count}");
        return sb.ToString();
    }
}
