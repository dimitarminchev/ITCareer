using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MiniORM.App.Data.Entities
{
    public class Project
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<EmployeeProject> EmployeeProjects { get; }
    }
}
