using CrudWithOrm.Data;
using CrudWithOrm.Data.Models;

/// <summary>
/// Task "CRUD with ORM" namespace.
/// </summary>
namespace CrudWithOrm.Business
{
    /// <summary>
    /// Task "CRUD with ORM" class ProductBusiness.
    /// </summary>
    public class ProductBusiness
    {
        private ProductContext productContext;

        /// <summary>
        /// Get All Products
        /// </summary>
        /// <returns>Products Collection</returns>
        public List<Product> GetAll()
        {
            using (productContext = new ProductContext())
            {
                return productContext.Products.ToList();
            }
        }

        /// <summary>
        /// Get Single Product
        /// </summary>
        /// <param name="id">Identifyer</param>
        /// <returns>Product</returns>
        public Product Get(int id)
        {
            using (productContext = new ProductContext())
            {
                return productContext.Products.Find(id);
            }
        }

        /// <summary>
        /// Add Product
        /// </summary>
        /// <param name="product">Product</param>
        public void Add(Product product)
        {
            using (productContext = new ProductContext())
            {
                // Add product
                productContext.Products.Add(product);

                // Save Changes to Databaser
                productContext.SaveChanges();
            }
        }

        /// <summary>
        /// Update Product
        /// </summary>
        /// <param name="product">Product</param>
        /// <exception cref="Exception">If enrtry is not found.</exception>
        public void Update(Product product)
        {
            using (productContext = new ProductContext())
            {
                var oldProduct = productContext.Products.Find(product.Id);

                if (oldProduct != null)
                {
                    // Update Product Values
                    productContext.Entry(oldProduct).CurrentValues.SetValues(product);

                    // Save Changes to Database
                    productContext.SaveChanges();
                }
                else
                {
                    throw new Exception("Entry not found!");
                }
            }
        }

        /// <summary>
        /// Delete Product
        /// </summary>
        /// <param name="id">Identifyer</param>
        /// <exception cref="Exception">If enrtry is not found.</exception>
        public void Delete(int id)
        {
            using (productContext = new ProductContext())
            {
                var product = productContext.Products.Find(id);

                if (product != null)
                {
                    // Delete Product
                    productContext.Products.Remove(product);

                    // Save Changes to Database
                    productContext.SaveChanges();
                }
                else
                {
                    throw new Exception("Entry not found!");
                }
            }
        }
    }
}
