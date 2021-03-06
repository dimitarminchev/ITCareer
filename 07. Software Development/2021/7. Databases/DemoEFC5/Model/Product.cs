using System;

namespace DemoEFC5.Model
{
    /// <summary>
    /// Единичен продукт
    /// </summary>
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public DateTime Delivery { get; set; }
    }
}
