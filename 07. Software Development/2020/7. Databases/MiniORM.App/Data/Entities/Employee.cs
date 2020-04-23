using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniORM.App.Data.Entities
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        [Required]
        public string LastName { get; set; }

        public bool IsEmployed { get; set; }

        [ForeignKey(nameof(Department))]
        public int DepartmentId { get; set; }

        public Department Department { get; set; }

        public ICollection<EmployeeProject> EmployeeProjects { get; }
    }
}
