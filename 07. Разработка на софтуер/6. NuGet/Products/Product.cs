using System.Text;
/// <summary>
/// Task "Products" namespace.
/// </summary>
namespace Products
{
    /// <summary>
    /// Task "Products" Product Class
    /// </summary>
    public class Product
    {
        /// <summary>
        /// номер на продукта
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// име на продукта
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// цена на продукта
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// наличност на продукта
        /// </summary>
        public int Stock { get; set; }

        /// <summary>
        /// срок на годност на продукта
        /// </summary>
        public DateTime Expiry { get; set; }

        /// <summary>
        /// Contsructor
        /// </summary>
        public Product
        (
            int Id, 
            string Name, 
            decimal Price, 
            int Stock, 
            DateTime Expiry
        )
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
            this.Stock = Stock;
            this.Expiry = Expiry;
        }

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Id: {Id}, ");
            sb.Append($"Name: {Name}, ");
            sb.Append($"Price: {Price}, ");
            sb.Append($"Stock: {Stock}, ");
            sb.Append($"Expiry: {Expiry} ");
            sb.Append(Environment.NewLine);

            return sb.ToString();
        }
    }
}
