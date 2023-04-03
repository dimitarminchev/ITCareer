/// <summary>
/// Refactoring Task "Orders" namespace.
/// </summary>
namespace Orders.Models
{
    /// <summary>
    /// Category Class
    /// </summary>
    public class Category
    {
        /// <summary>
        /// Category Identifyer
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Category Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Category Description
        /// </summary>
        public string Description { get; set; }
    }
}
