using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;

public class StoreController
{
    private List<Store> stores = new List<Store>();

    // CreateStore:{name}:{type}
    public string CreateStore(List<string> args)
    {
        var name = args[0];
        var type = args[1];

        if (stores.Contains(new Store(name, type)))
        {
            return $"Store {name} is already registered!";
        }

        stores.Add(new Store(name, type));
        return $"Store {name} was successfully registerd in the system!";
    }

    // ReceiveProduct:{type}:{name}:{quantity}:{price}:{percentageMarkup}:{storeName}
    public string ReceiveProduct(List<string> args)
    {
        string type = args[0];
        string name = args[1];
        int quantity = int.Parse(args[2]);
        float price = float.Parse(args[3]);
        float percentageMarkup = float.Parse(args[2]);
        var storeName = args[5];

        if (type != "Food" && type != "Drink")
        return $"Product {type} is invalid!";

        Store store = stores.FirstOrDefault(x => x.Name == storeName);
        if (store == null) return $"Invalid Store: {storeName}. Cannot find it in system!";

        Product product = null;
        if (type == "Food") product = new Food(name, quantity, price, percentageMarkup);
        if (type == "Drink") product = new Drink(name, quantity, price, percentageMarkup);

        if (!store.ReceiveProduct(product))
            return $"Product {name} was already delivered to {storeName}!";

        return $"Product {name} was successfully delivered to {storeName}!";
    }

    // SellProduct:{name}:{quantity}:{storeName}
    public string SellProduct(List<string> args)
    {
        string name = args[0];
        int quantity = int.Parse(args[1]);
        string storeName = args[2];

        Store store = stores.FirstOrDefault(x => x.Name == storeName);
        if (store == null) return $"Invalid Store: {storeName}. Cannot find it in system!";

        if (!store.SellProduct(name, quantity))
            return $"Product {name} was already sold out!";

        return $"Product {name} was successfully bought from {storeName}!";
    }

    // StoreInfo:{storeName}
    public string StoreInfo(List<string> args)
    {
        string storeName = args[0];

        Store store = stores.FirstOrDefault(x => x.Name == storeName);
        if (store == null) return $"Invalid Store: {storeName}. Cannot find it in system!";

        return store.ToString();
    }

    public string Shutdown()
    {
        stores = stores.OrderByDescending(x => x.Revenue).ThenBy(y => y.Name).ToList();

        var sum = stores.Sum(x => x.Revenue);

        var sb = new StringBuilder();
        sb.Append($"Stores: {stores.Count()}" + Environment.NewLine);
        foreach (var store in stores)
            sb.Append(StoreInfo(new List<string>() { store.Name }));
        sb.Append($"\nSystem Store Revenues: {sum:f2}BGN" + Environment.NewLine);

        return sb.ToString();
    }
}
