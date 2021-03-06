

namespace DemoEFC5.Model
{
    // EFC5
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Контекст на базата данни
    /// </summary>
    public class ProductDatabaseContext : DbContext
    {
        /// <summary>
        /// Таблица с продуктите
        /// </summary>
        public DbSet<Product> Products { get; set; }

        /// <summary>
        /// Таблица с поръчка
        /// </summary>
        public DbSet<Order> Orders { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        public ProductDatabaseContext()
        {
            // Гарантира ми че базата данни ще бъде автоматично съзадена
            Database.EnsureCreated();
        }

        /// <summary>
        /// Конфигуриране на контекста
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Database=products; Integrated Security=True");
        }
    }
}
