using DataBase.Entity;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataBase
{
    public class ChushkaDatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conn = @"Data Source=(localdb)\ProjectsV13; Initial Catalog=ChushkaDb";
            optionsBuilder.UseSqlServer(conn);
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
