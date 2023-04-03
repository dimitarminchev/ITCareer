/// <summary>
/// Refactoring Task "Orders" namespace.
/// </summary>
namespace Orders.Models
{
    /// <summary>
    /// Class Product
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Product Identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Product Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Category Identifyer
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// Unit Price
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Units In Stock
        /// </summary>
        public int UnitsInStock { get; set; }
    }
}
