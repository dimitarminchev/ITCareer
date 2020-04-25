using Microsoft.EntityFrameworkCore;

namespace CrudWithORM.Data
{
    public class ProductContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Database=products; Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);
            modelBuilder.HasAnnotation("ProductVersion", "2.2.2-servicing-10034");
            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("products", "shop");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.Price).IsRequired();
                entity.Property(e => e.Stock).IsRequired();
            });
        }
        public ProductContext(DbContextOptions<ProductContext> options)
        : base(options)
        {

        }
        public ProductContext()
        {
            // nope
        }

        public DbSet<Product> Products { get; set; }
    }
 }
