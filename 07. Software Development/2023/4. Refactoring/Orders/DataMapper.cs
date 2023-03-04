using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Orders
{
    using Orders.Models;

    public class DataMapper
    {
        private string categoriesFileName;
        private string productsFileName;
        private string ordersFileName;

        /// <summary>
        /// Constructor
        /// </summary>
        public DataMapper(string categoriesFileName, string productsFileName, string ordersFileName)
        {
            this.categoriesFileName = categoriesFileName;
            this.productsFileName = productsFileName;
            this.ordersFileName = ordersFileName;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public DataMapper() : this
        (
            "Data/categories.txt", 
            "Data/products.txt", 
            "Data/orders.txt"
        )
        {
            // empty
        }

        /// <summary>
        /// Get All Categories
        /// </summary>
        public IEnumerable<Category> getAllCategories()
        {
            var cat = readFileLines(this.categoriesFileName, true);
            return cat
                .Select(c => c.Split(','))
                .Select(c => new Category
                {
                    Id = int.Parse(c[0]),
                    Name = c[1],
                    Description = c[2]
                });
        }

        /// <summary>
        /// Get All Products
        /// </summary>
        public IEnumerable<Product> getAllProducts()
        {
            var prod = readFileLines(this.productsFileName, true);
            return prod
                .Select(p => p.Split(','))
                .Select(p => new Product
                {
                    Id = int.Parse(p[0]),
                    Name = p[1],
                    CategoryId = int.Parse(p[2]),
                    UnitPrice = decimal.Parse(p[3]),
                    UnitsInStock = int.Parse(p[4]),
                });
        }

        /// <summary>
        /// Get All Orders
        /// </summary>
        public IEnumerable<Order> getAllOrders()
        {
            var ord = readFileLines(this.ordersFileName, true);
            return ord
                .Select(p => p.Split(','))
                .Select(p => new Order
                {
                    Id = int.Parse(p[0]),
                    ProductId = int.Parse(p[1]),
                    Quantity = int.Parse(p[2]),
                    Discount = decimal.Parse(p[3]),
                });
        }

        /// <summary>
        /// Get All Products
        /// </summary>
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
