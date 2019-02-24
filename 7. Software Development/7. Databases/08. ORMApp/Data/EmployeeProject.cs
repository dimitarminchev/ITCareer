using MiniORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.ORMApp.Data
{
    [Entity(TableName = "EmployeesProjects")]
    class EmployeeProject
    {
        [Column(ColumnName = "EmployeeId")]
        private int employeeId;

        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }


        [Column(ColumnName = "ProjectId")]
        private int projectId;

        public int ProjectId
        {
            get { return projectId; }
            set { projectId = value; }
        }

        public EmployeeProject(int employeeId, int projectId)
        {
            this.EmployeeId = employeeId;
            this.ProjectId = projectId;
        }

    }
}
