using System;
using System.Collections.Generic;

namespace _11_EntityFrameworkMysql.Models
{
    public partial class Employees
    {
        public Employees()
        {
            DeptEmp = new HashSet<DeptEmp>();
            DeptManager = new HashSet<DeptManager>();
            Salaries = new HashSet<Salaries>();
            Titles = new HashSet<Titles>();
        }

        public int EmpNo { get; set; }
        public DateTime BirthDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime HireDate { get; set; }

        public virtual ICollection<DeptEmp> DeptEmp { get; set; }
        public virtual ICollection<DeptManager> DeptManager { get; set; }
        public virtual ICollection<Salaries> Salaries { get; set; }
        public virtual ICollection<Titles> Titles { get; set; }
    }
}
