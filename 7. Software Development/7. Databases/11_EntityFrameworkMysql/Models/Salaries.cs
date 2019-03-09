using System;
using System.Collections.Generic;

namespace _11_EntityFrameworkMysql.Models
{
    public partial class Salaries
    {
        public int EmpNo { get; set; }
        public int Salary { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        public virtual Employees EmpNoNavigation { get; set; }
    }
}
