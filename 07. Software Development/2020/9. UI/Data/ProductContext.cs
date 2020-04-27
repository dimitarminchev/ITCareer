using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class ProductContext : DbContext
    {

        public DbSet<Product> Products { get; set; }

        public ProductContext()
        {
            Database.EnsureCreated();
        }

        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
             Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB.;Database=shop");
        }
    }
 }
