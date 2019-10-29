using _Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Business
{
    public class ProductBusiness
    {
        private ProductsContext productContext;

        public List<Product> GetAll()
        {
            using (productContext = new ProductsContext())
            {
                return productContext.Products.ToList();
            }
        }

        public Product Get(int id)
        {
            using (productContext = new ProductsContext())
            {
                return productContext.Products.Find(id);
            }
        }

        public void Add(Product product)
        {
            using (productContext = new ProductsContext())
            {
                productContext.Products.Add(product);
                productContext.SaveChanges();
            }
        }

        public void Update(Product product)
        {
            using (productContext = new ProductsContext())
            {
                var item = productContext.Products.Find(product.Id);
                if (item != null)
                {
                    productContext.Entry(item).CurrentValues.SetValues(product);
                    productContext.SaveChanges();
                }
            }
        }

        public void Delete(int id)
        {
            using (productContext = new ProductsContext())
            {
                var product = productContext.Products.Find(id);
                if (product != null)
                {
                    productContext.Products.Remove(product);
                    productContext.SaveChanges();
                }
            }
        }
    }
}
