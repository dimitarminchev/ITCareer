using CrudWithoutOrm.Common;
using CrudWithoutOrm.Data;

/// <summary>
/// Task "CRUD without ORM" namespace.
/// </summary>
namespace CrudWithoutOrm.Business
{
    /// <summary>
    /// Task "CRUD without ORM" ProductBusiness class.
    /// </summary>
    public class ProductBusiness
    {
        private ProductData manager = new ProductData();

        /// <summary>
        /// Get All Products
        /// </summary>
        /// <returns>Products Collection</returns>
        public List<Product> GetAll()
        {
            return this.manager.GetAll();
        }

        /// <summary>
        /// Get Single Product
        /// </summary>
        /// <param name="id">Identifyer</param>
        /// <returns>Product</returns>
        public Product Get(int id)
        { 
            return this.manager.Get(id);
        }

        /// <summary>
        /// Add Product
        /// </summary>
        /// <param name="product">Product</param>
        public void Add(Product product)
        {
            this.manager.Add(product);
        }

        /// <summary>
        /// Update Product
        /// </summary>
        /// <param name="product">Product</param>
        public void Update(Product product) 
        {
            this.manager.Update(product);
        }

        /// <summary>
        /// Delete Product
        /// </summary>
        /// <param name="id">Identifyer</param>
        public void Delete(int id) 
        {
            this.manager.Delete(id);
        }
    }
}
