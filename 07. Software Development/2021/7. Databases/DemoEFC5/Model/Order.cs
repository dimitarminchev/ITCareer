using System;

namespace DemoEFC5.Model
{
    /// <summary>
    /// Единична поръчка
    /// </summary>
    public class Order
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public int Quantity { get; set; }

        public Product Product { get; set; }
    }
}
