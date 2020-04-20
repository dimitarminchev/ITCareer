using System;

namespace _1.JsonApp
{
    /// <summary>
    /// Продукт
    /// </summary>
    public class Product
    {
        private int id;

        /// <summary>
        /// Уникален идентификационен номер
        /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        /// <summary>
        /// Име на продукт
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private decimal price;

        /// <summary>
        /// Цена на продукт
        /// </summary>
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        private int stock;

        /// <summary>
        /// Наличност на продукт
        /// </summary>
        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        private DateTime expiry;

        /// <summary>
        /// Срок на годнист на продукт
        /// </summary>
        public DateTime Expiry
        {
            get { return expiry; }
            set { expiry = value; }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="id">Номер</param>
        /// <param name="name">Име</param>
        /// <param name="price">Цена</param>
        /// <param name="stock">Наличност</param>
        /// <param name="expiry">Срок на годност</param>
        public Product(int id, string name, decimal price, int stock, DateTime expiry)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.stock = stock;
            this.expiry = expiry;
        }
    }
}
