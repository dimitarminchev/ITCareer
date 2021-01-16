using Microsoft.EntityFrameworkCore;
namespace Data
{

    public class CarContext : DbContext
    {
        public CarContext()
        {
            ;;
        }
        public CarContext(DbContextOptions<CarContext> options) : base(options)
        {
            ;;
        }

        public virtual DbSet<Car> Cars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CarsDb;");
            optionBuilder.UseLazyLoadingProxies();
        }
    }
}
