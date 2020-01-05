using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CHUSHKA.Models
{
    public enum TypeType { Food, Domestic, Health, Cosmetic, Other }

    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public TypeType Type { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
