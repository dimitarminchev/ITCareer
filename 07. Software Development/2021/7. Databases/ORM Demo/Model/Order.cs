using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Demo.Model
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
