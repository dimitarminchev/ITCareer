
namespace CrudWithoutORM.Common
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public Product(int id, string name, decimal price, int stock)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Stock = stock;
        }

        public Product()
        {
            // nope
        }
    }
}
