using System.ComponentModel.DataAnnotations;

/// <summary>
/// Task "CRUD with ORM" namespace.
/// </summary>
namespace CrudWithOrm.Data.Models
{
    /// <summary>
    /// Task "CRUD with ORM" class Product.
    /// </summary>
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Stock { get; set; }
    }
}
