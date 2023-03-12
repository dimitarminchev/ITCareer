/// <summary>
/// Task "CRUD without ORM" namespace.
/// </summary>
namespace CrudWithoutOrm.Common
{
    /// <summary>
    /// Task "CRUD without ORM" database class
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Product Identifyer
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Product Nape
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Product Price
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Product Stock
        /// </summary>
        public int Stock { get; set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Product()
        {
            // empty
        }

        /// <summary>
        /// Overloaded Constructor
        /// </summary>
        /// <param name="id">Idetifyer</param>
        /// <param name="name">Name</param>
        /// <param name="price">Price</param>
        /// <param name="stock">Stock</param>
        public Product(int id, string name, decimal price, int stock)
        {
            this.Id = id;
            this.Name = name;

            this.Price = price;
            this.Stock = stock;
        }
    }
}
