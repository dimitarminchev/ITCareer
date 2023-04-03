using System.Globalization;

/// <summary>
/// Refactoring Task "Orders" namespace.
/// </summary>
namespace Orders
{
    using Orders.Models;

    /// <summary>
    /// Refactoring Task "Orders" main program class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Refactoring Task "Orders" main program method.
        /// </summary>
        /// <example>
        /// Côte de Blaye
        /// Thüringer Rostbratwurst
        /// Mishi Kobe Niku
        /// Sir Rodney's Marmalade
        /// Carnarvon Tigers
        /// ----------
        /// Beverages: 12
        /// Condiments: 12
        /// Produce: 5
        /// Meat/Poultry: 6
        /// Seafood: 12
        /// Dairy Products: 10
        /// Confections: 13
        /// Grains/Cereals: 7
        /// ----------
        /// Camembert Pierrot: 1577
        /// Raclette Courdavault: 1496
        /// Gorgonzola Telino: 1397
        /// Gnocchi di nonna Alice: 1263
        /// Pavlova: 1158
        /// ----------
        /// Beverages: 309582.25
        /// </example>
        /// <param name="args">No arguments needed.</param>
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            var dataMapper = new DataMapper();
            var categories = dataMapper.getAllCategories();
            var products = dataMapper.getAllProducts();
            var orders = dataMapper.getAllOrders();

            // Names of the 5 most expensive products
            var top5expexsiveProducts = products
                .OrderByDescending(p => p.UnitPrice)
                .Take(5)
                .Select(p => p.Name);
            Console.WriteLine(string.Join(Environment.NewLine, top5expexsiveProducts));

            Console.WriteLine(new string('-', 10));

            // Number of products in each category
            var productsNumbersByCategories = products
                .GroupBy(p => p.CategoryId)
                .Select(grp => new { Category = categories.First(c => c.Id == grp.Key).Name, Count = grp.Count() })
                .ToList();
            foreach (var item in productsNumbersByCategories)
            {
                Console.WriteLine("{0}: {1}", item.Category, item.Count);
            }

            Console.WriteLine(new string('-', 10));

            // The 5 top products (by order quantity)
            var top5productsOrderByQuantity = orders
                .GroupBy(o => o.ProductId)
                .Select(grp => new { Product = products.First(p => p.Id == grp.Key).Name, Quantities = grp.Sum(grpgrp => grpgrp.Quantity) })
                .OrderByDescending(q => q.Quantities)
                .Take(5);
            foreach (var item in top5productsOrderByQuantity)
            {
                Console.WriteLine("{0}: {1}", item.Product, item.Quantities);
            }

            Console.WriteLine(new string('-', 10));

            // The most profitable category
            var mostProfitableCategory = orders
                .GroupBy(o => o.ProductId)
                .Select(g => new { catId = products.First(p => p.Id == g.Key).CategoryId, price = products.First(p => p.Id == g.Key).UnitPrice, quantity = g.Sum(p => p.Quantity) })
                .GroupBy(gg => gg.catId)
                .Select(grp => new { category_name = categories.First(c => c.Id == grp.Key).Name, total_quantity = grp.Sum(g => g.quantity * g.price) })
                .OrderByDescending(g => g.total_quantity)
                .First();
            Console.WriteLine("{0}: {1}", mostProfitableCategory.category_name, mostProfitableCategory.total_quantity);
        }
    }
}