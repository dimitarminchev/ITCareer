using System;
using System.Collections.Generic;

namespace _11_EntityFrameworkMysql.Models
{
    public partial class Departments
    {
        public Departments()
        {
            DeptEmp = new HashSet<DeptEmp>();
            DeptManager = new HashSet<DeptManager>();
        }

        public string DeptNo { get; set; }
        public string DeptName { get; set; }

        public virtual ICollection<DeptEmp> DeptEmp { get; set; }
        public virtual ICollection<DeptManager> DeptManager { get; set; }
    }
}
