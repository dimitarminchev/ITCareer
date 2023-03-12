using CrudWithOrm.Data.Models;
using Microsoft.EntityFrameworkCore;

/// <summary>
/// Task "CRUD with ORM" namespace.
/// </summary>
namespace CrudWithOrm.Data
{
    /// <summary>
    /// Task "CRUD with ORM" class Product.
    /// </summary>
    public class ProductContext : DbContext
    {
        /// <summary>
        /// Connection String
        /// </summary>
        private const string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Products;Integrated Security=True";

        /// <summary>
        /// Product Table from Database
        /// </summary>
        public DbSet<Product> Products { get; set; }

        /// <summary>
        /// Copnstructor
        /// </summary>
        public ProductContext() : base()
        {
            // empty
        }

        /// <summary>
        /// Set Connection String Configuration
        /// </summary>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
