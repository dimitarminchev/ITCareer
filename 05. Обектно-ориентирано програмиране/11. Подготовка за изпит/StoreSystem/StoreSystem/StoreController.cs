using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
// using System.Data;

public class StoreController
{
    private List<Store> stores = null;

    /// <summary>
    /// Constructor
    /// </summary>
    public StoreController()
    {
        stores = new List<Store>();
    }

    /// <summary>
    /// CreateStore:{name}:{type}
    /// </summary>
    public string CreateStore(List<string> args)
    {
        if (stores.Any(x => x.Name.Equals(args[0])))
        {
            return $"Store {args[0]} is already registered!";
        }

        try
        {
            stores.Add(new Store(args[0], args[1]));
        }
        catch (ArgumentException e)
        {
            return e.Message;
        }

        return $"Store {args[0]} was successfully registerd in the system!";
    }

    /// <summary>
    /// ReceiveProduct:{type}:{name}:{quantity}:{price}:{percentageMarkup}:{storeName}
    /// </summary>
    public string ReceiveProduct(List<string> args)
    {
        if (!stores.Any(x => x.Name.Equals(args[5])))
        {
            return $"Invalid Store: {args[5]}. Cannot find it in system!";
        }

        if (stores.First(x => x.Name.Equals(args[5])).GetProduct(args[1]) != null)
        {
            return $"Product {args[1]} was already delivered to {args[5]}!";
        }

        if (args[0].Equals("Food"))
        {
            try
            {
                stores.First(x => x.Name.Equals(args[5])).ReceiveProduct(new Food(
                    args[1],
                    int.Parse(args[2]),
                    double.Parse(args[3]),
                    double.Parse(args[4])
                ));
            }
            catch (ArgumentException e)
            {
                return e.Message;
            }
        }
        else if (args[0].Equals("Drink"))
        {
            try
            {
                stores.First(x => x.Name.Equals(args[5])).ReceiveProduct(new Drink(
                    args[1], 
                    int.Parse(args[2]), 
                    double.Parse(args[3]), 
                    double.Parse(args[4])
                ));
            }
            catch (ArgumentException e)
            {
                return e.Message;
            }
        }
        else
        {
            return $"Product {args[0]} is invalid!";
        }

        return $"Product {args[1]} was successfully delivered to {args[5]}!";
    }

    /// <summary>
    /// SellProduct:{name}:{quantity}:{storeName}
    /// </summary>
    public string SellProduct(List<string> args)
    {
        if (!stores.Any(x => x.Name.Equals(args[2])))
        {
            return $"Invalid Store: {args[2]}. Cannot find it in system!";
        }

        if (stores.First(x => x.Name.Equals(args[2])).GetProduct(args[0]) == null)
        {
            return $"Product {args[0]} was already sold out!";
        }

        if (!stores.First(x => x.Name.Equals(args[2])).SellProduct(args[0], int.Parse(args[1])))
        {
            return $"Product {args[0]} was already sold out!";
        }

        return $"Product {args[0]} was successfully bought from {args[2]}!";
    }

    /// <summary>
    /// StoreInfo:{storeName}
    /// </summary>
    public string StoreInfo(List<string> args)
    {
        if (!stores.Any(x => x.Name.Equals(args[0])))
        {
            return $"Invalid Store: {args[0]}. Cannot find it in system!";
        }

        return stores.First(x => x.Name.Equals(args[0])).ToString();
    }

    /// <summary>
    /// Shutdown
    /// </summary>
    public string Shutdown()
    {
        stores = stores.OrderByDescending(x => x.Revenue).ThenBy(x => x.Name).ToList();

        StringBuilder stringBuilder = new StringBuilder();

        stringBuilder.AppendLine($"Stores: {stores.Count}");
        stores.ForEach(x => stringBuilder.AppendLine(x.ToString()));
        stringBuilder.Append($"System Store Revenues: {stores.Sum(x => x.Revenue):F2}BGN");

        return stringBuilder.ToString();
    }
}
