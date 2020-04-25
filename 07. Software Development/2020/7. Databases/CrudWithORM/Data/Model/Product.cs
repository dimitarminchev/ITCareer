using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudWithORM.Data
{
    [Table("products")]
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Stock { get; set; }
    }
}
