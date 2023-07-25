﻿using System.Collections.Generic;

namespace CodeFirst.Entity
{
    public class Company : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
