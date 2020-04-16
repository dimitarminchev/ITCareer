using System.Collections.Generic;
using System.Linq;
using Orders.Models;
using System.IO;

namespace Orders
{
    public class DataMapper
    {
        private string categoriesFileName;
        private string productsFileName;
        private string ordersFileName;

        public DataMapper(string categoriesFileName, string productsFileName, string ordersFileName)
        {
            this.categoriesFileName = categoriesFileName;
            this.productsFileName = productsFileName;
            this.ordersFileName = ordersFileName;
        }

        public DataMapper() : this("../../Data/categories.txt", "../../Data/products.txt", "../../Data/orders.txt")
        {

        }

        public IEnumerable<Category> getAllCategories()
        {
            var categoriesData = readFileLines(this.categoriesFileName, true);
            return categoriesData.Select(categoryRecord => categoryRecord.Split(','))
                                .Select(categoryRecord => new Category
                                {
                                    Id = int.Parse(categoryRecord[0]),
                                    Name = categoryRecord[1],
                                    Description = categoryRecord[2]
                                });
        }

        public IEnumerable<Product> getAllProducts()
        {
            var productsData = readFileLines(this.productsFileName, true);
            return productsData.Select(productRecord => productRecord.Split(','))
                                .Select(productRecord => new Product
                                {
                                    Id = int.Parse(productRecord[0]),
                                    Name = productRecord[1],
                                    CategoryId = int.Parse(productRecord[2]),
                                    UnitPrice = decimal.Parse(productRecord[3]),
                                    UnitsInStock = int.Parse(productRecord[4]),
                                });
        }

        public IEnumerable<Order> getAllOrders()
        {
            var ordersData = readFileLines(this.ordersFileName, true);
            return ordersData.Select(orderRecord => orderRecord.Split(','))
                             .Select(orderRecord => new Order
                             {
                                 Id = int.Parse(orderRecord[0]),
                                 ProductId = int.Parse(orderRecord[1]),
                                 Quantity = int.Parse(orderRecord[2]),
                                 Discount = decimal.Parse(orderRecord[3]),
                             });
        }

        private List<string> readFileLines(string filename, bool hasHeader)
        {
            var allLines = new List<string>();
            using (var reader = new StreamReader(filename))
            {
                string currentLine;
                if (hasHeader)
                {
                    reader.ReadLine();
                }

                while ((currentLine = reader.ReadLine()) != null)
                {
                    allLines.Add(currentLine);
                }
            }

            return allLines;
        }
    }
}