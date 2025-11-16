using System;
using System.Collections.Generic;

public class Controller
{
    private Dictionary<string, Category> categories;

    public Controller()
    {
        categories = new Dictionary<string, Category>();
    }

    public string AddCategory(List<string> args)
    {
        var categoryTitle = args[0];

        categories.Add(categoryTitle, new Category(categoryTitle));

        return $"Created Category {categoryTitle}!";
    }

    public string AddProductToCategory(List<string> args)
    {
        var categoryTitle = args[0];
        var productTitle = args[1];
        var price = double.Parse(args[2]);
        var type = args[3];

        if (type == "physical")
        {
            var quantity = double.Parse(args[4]);
            categories[categoryTitle].AddProduct(new PhysicalProduct(productTitle, price, quantity));
        }
        else
        {
            var downloadUrl = args[4];
            categories[categoryTitle].AddProduct(new OnlineProduct(productTitle, price, downloadUrl));
        }
        return $"Added product {productTitle} to Category {categoryTitle}!";
    }

    public string GetMinPrice(List<string> args)
    {
        var categoryTitle = args[0];
        var price = categories[categoryTitle].MinPrice();
        return $"Min price in {categoryTitle} is {price:F2} EUR";
    }

    public string GetProductsInRange(List<string> args)
    {
        var categoryTitle = args[0];
        var from = double.Parse(args[1]);
        var to = double.Parse(args[2]);
        var products = categories[categoryTitle].GetProductsInRange(from, to);
        return string.Join(Environment.NewLine, products);
    }

    public string GetProductsExpensiveToCheap(List<string> args)
    {
        var categoryTitle = args[0];
        var products = categories[categoryTitle].GetProductsExpensiveToCheap();
        return string.Join(Environment.NewLine, products);
    }

    public string GetProductsCheapToExpensive(List<string> args)
    {
        var categoryTitle = args[0];
        var products = categories[categoryTitle].GetProductsCheapToExpensive();
        return string.Join(Environment.NewLine, products);
    }
}
