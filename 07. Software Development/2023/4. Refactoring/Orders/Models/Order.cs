/// <summary>
/// Refactoring Task "Orders" namespace.
/// </summary>
namespace Orders.Models
{
    /// <summary>
    /// Class Order
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Order Identifyer
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Product Identifyer
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Product Quantity
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Order Discount
        /// </summary>
        public decimal Discount { get; set; }
    }
}
