using _12_ORM_CRUD.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_ORM_CRUD.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext()
            :base("name=ProductContext")
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
