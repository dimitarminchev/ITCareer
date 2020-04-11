using System;
using System.Collections.Generic;

namespace _11_EntityFrameworkMysql.Models
{
    public partial class DeptEmp
    {
        public int EmpNo { get; set; }
        public string DeptNo { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        public virtual Departments DeptNoNavigation { get; set; }
        public virtual Employees EmpNoNavigation { get; set; }
    }
}
