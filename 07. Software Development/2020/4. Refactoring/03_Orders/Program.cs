using System;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace Orders
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            var dataMapper = new DataMapper();
            var categories = dataMapper.getAllCategories();
            var products = dataMapper.getAllProducts();
            var orders = dataMapper.getAllOrders();

            // Names of the 5 most expensive products
            var fiveMostExpensiveProducts = products
                .OrderByDescending(product => product.UnitPrice)
                .Take(5)
                .Select(product => product.Name);

            Console.WriteLine(string.Join(Environment.NewLine, fiveMostExpensiveProducts));
            Console.WriteLine(new string('-', 10));

            // Number of products in each category
            var numberOfProductsInCategory = products
                .GroupBy(product => product.CategoryId)
                .Select(group => new {
                    Category = categories.First(category => category.Id == group.Key).Name,
                    Count = group.Count()
                })
                .ToList();

            foreach (var product in numberOfProductsInCategory)
            {
                Console.WriteLine("{0}: {1}", product.Category, product.Count);
            }

            Console.WriteLine(new string('-', 10));

            // The 5 top products (by order quantity)
            var fiveTopProductsByOrderQuantity = orders
                .GroupBy(order => order.ProductId)
                .Select(group => new {
                    Product = products.First(product => product.Id == group.Key).Name,
                    Quantity = group.Sum(item => item.Quantity)
                })
                .OrderByDescending(group => group.Quantity)
                .Take(5);

            foreach (var product in fiveTopProductsByOrderQuantity)
            {
                Console.WriteLine("{0}: {1}", product.Product, product.Quantity);
            }

            Console.WriteLine(new string('-', 10));

            // The most profitable category
            var mostProfitableCategory = orders
                .GroupBy(order => order.ProductId)
                .Select(group => new {
                    categatyId = products.First(product => product.Id == group.Key).CategoryId,
                    Price = products.First(product => product.Id == group.Key).UnitPrice,
                    Quantity = group.Sum(product => product.Quantity)
                })
                .GroupBy(order => order.categatyId)
                .Select(group => new {
                    CategoryName = categories.First(category => category.Id == group.Key).Name,
                    TotalQuantity = group.Sum(item => item.Quantity * item.Price)
                })
                .OrderByDescending(group => group.TotalQuantity)
                .First();
            Console.WriteLine("{0}: {1}", mostProfitableCategory.CategoryName, mostProfitableCategory.TotalQuantity);
        }
    }
}
