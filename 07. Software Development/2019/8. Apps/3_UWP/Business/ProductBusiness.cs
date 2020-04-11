using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _Data;

namespace _Business
{
    public class ProductBusiness
    {
        private ProductsContext productsContext;

        public List<Product> GetAll()
        {
            using (productsContext = new ProductsContext())
            {
                return productsContext.Products.ToList();
            }
        }

        public Product Get(int id)
        {
            using (productsContext = new ProductsContext())
            {
                return productsContext.Products.Find(id);
            }
        }

        public void Add(Product product)
        {
            using (productsContext = new ProductsContext())
            {
                productsContext.Products.Add(product);
                productsContext.SaveChanges();
            }
        }

        public void Update(Product product)
        {
            using (productsContext = new ProductsContext())
            {
                var item = productsContext.Products.Find(product.Id);
                if (item != null)
                {
                    productsContext.Entry(item).CurrentValues.SetValues(product);
                    productsContext.SaveChanges();
                }
            }
        }

        public void Delete(int id)
        {
            using (productsContext = new ProductsContext())
            {
                var product = productsContext.Products.Find(id);
                if (product != null)
                {
                    productsContext.Products.Remove(product);
                    productsContext.SaveChanges();
                }
            }
        }
    }
}
