using System.Data.Entity;

namespace CrudWithORM.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext()
            : base("name=ProductContext")
        {
            // nope
        }
        public DbSet<Product> Products { get; set; }
    }
 }
