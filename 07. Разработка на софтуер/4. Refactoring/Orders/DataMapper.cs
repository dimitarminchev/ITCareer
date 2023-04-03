/// <summary>
/// Refactoring Task "Orders" namespace.
/// </summary>
namespace Orders
{
    using Orders.Models;

    /// <summary>
    /// Map files to object in classes
    /// </summary>
    public class DataMapper
    {
        private string categoriesFileName;
        private string productsFileName;
        private string ordersFileName;

        /// <summary>
        /// Overloaded Constructor
        /// </summary>
        /// <param name="categoriesFileName">Comma separated file for Categories</param>
        /// <param name="productsFileName">Comma separated file for Products</param>
        /// <param name="ordersFileName">Comma separated file for Orders</param>
        public DataMapper(string categoriesFileName, string productsFileName, string ordersFileName)
        {
            this.categoriesFileName = categoriesFileName;
            this.productsFileName = productsFileName;
            this.ordersFileName = ordersFileName;
        }

        /// <summary>
        /// Default Constructor
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
        /// <returns>Collection of Category Objects</returns>
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
        /// <returns>Collection of Products Objects</returns>
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
        /// <returns>Collection of Orders Objects</returns>
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
