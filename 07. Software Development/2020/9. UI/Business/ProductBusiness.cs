using System.Collections.Generic;
using System.Linq;
using Data;

namespace Business
{
    public class ProductBusiness
    {

        private ProductContext productContext;

        public List<Product> GetAll()
        {
            using (productContext = new ProductContext())
            {
                return productContext.Products.ToList();
            }
        }

        public Product Get(int id)
        {
            using (productContext = new ProductContext())
            {
                return productContext.Products.Find(id);

            }
        }

        public void Add(Product product)
        {
            using (productContext = new ProductContext())
            {
                productContext.Products.Add(product);
                productContext.SaveChanges();
            }
        }

        public void Update(Product product)
        {
            using (productContext = new ProductContext())
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
            using (productContext = new ProductContext())
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
