namespace Products
{
    /// <summary>
    /// Product class.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Product identification property.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Product name property.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Product price property.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Product stock property.
        /// </summary>
        public int Stock { get; set; }

        /// <summary>
        /// Product expiry property.
        /// </summary>
        public DateTime Expiry { get; set; }

        /// <summary>
        /// Product class empty constructor.
        /// </summary>
        public Product()
        {
            // nope
        }

        /// <summary>
        /// Product class constructor.
        /// </summary>
        /// <param name="id">Identification</param>
        /// <param name="name">Product name</param>
        /// <param name="price">Product price</param>
        /// <param name="stock">Product stock</param>
        /// <param name="expiry">DateTime</param>
        public Product(int id, string name, decimal price, int stock, DateTime expiry)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Stock = stock;
            this.Expiry = expiry;
        }
    }
}
