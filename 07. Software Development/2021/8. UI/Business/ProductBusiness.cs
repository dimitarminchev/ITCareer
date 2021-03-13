namespace Business
{
    using System.Linq;
    using System.Collections.Generic;
    using Data;
    using Data.Model;

    /// <summary>
    /// Business Logic of the App (CRUD operations)
    /// </summary>
    public class ProductBusiness
    {
        private ProductContext productContext;

        /// <summary>
        /// Get all producst from the database
        /// </summary>
        public List<Product> GetAll()
        {
            using (productContext = new ProductContext())
            {
                return productContext.Products.ToList();
            }
        }

        /// <summary>
        /// Get single product from the database by Id
        /// </summary>
        public Product Get(int id)
        {
            using (productContext = new ProductContext())
            {
                return productContext.Products.Find(id);
            }
        }

        /// <summary>
        /// Add a product to the database
        /// </summary>
        public void Add(Product product)
        {
            using (productContext = new ProductContext())
            {
                productContext.Products.Add(product);
                productContext.SaveChanges();
            }
        }

        /// <summary>
        /// Update a single product in the database by Id.
        /// </summary>
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

        /// <summary>
        /// Deleate a product from the database by Id
        /// </summary>
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
