using CrudWithoutORM.Common;
using CrudWithoutORM.Data;
using System.Collections.Generic;

namespace CrudWithoutORM.Business
{
    class ProductBussiness
    {
        private ProductData manager = new ProductData();

        public List<Product> GetAll() => manager.GetAll();

        public Product Get(int id) => manager.Get(id);

        public void Add(Product product) => manager.Add(product);
        
        public void Update(Product product) => manager.Update(product);
        
        public bool Delete(int id) => manager.Delete(id);
    }
}
