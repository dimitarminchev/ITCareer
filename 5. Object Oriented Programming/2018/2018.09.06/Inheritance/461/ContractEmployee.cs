using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _461
{
    class ContractEmployee : BaseEmployee
    {
        public string employeeTask { get; private set; }
        public string employeeDepartment { get; private set; }

        public ContractEmployee(string employeeID, string employeeName, string employeeAddress, string employeeTask, string employeeDepartment) : base(employeeID, employeeName, employeeAddress)
        {
            this.employeeTask = employeeTask;
            this.employeeDepartment = employeeDepartment;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Employee Task: ", employeeTask);
            Console.WriteLine("Employee Name: ", employeeDepartment);
        }

        public override void CalculateSalary(int workingHours)
        {
            Console.WriteLine(250 + workingHours * 20);
        }

        public override void GetDepartment()
        {
            base.GetDepartment();
        }
    }
}
