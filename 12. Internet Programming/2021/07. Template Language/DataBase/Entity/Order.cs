using System;
using System.Collections.Generic;
using System.Text;

namespace DataBase.Entity
{
    public class Order : BaseEntity
    {
        public int MyProperty { get; set; }

        public string Client { get; set; }

        public DateTime OrderedOn { get; set; }

        public virtual Product Product { get; set; }
    }
}
