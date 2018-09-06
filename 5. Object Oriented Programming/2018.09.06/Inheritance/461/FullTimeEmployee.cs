using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _461
{
    public class FullTimeEmployee : BaseEmployee
    {
        public string employeePosition { get; private set; }
        public string employeeDepartment { get; private set; }

        public FullTimeEmployee(string employeeID, string employeeName, string employeeAddress, string employeePosition, string employeeDepartment) : base(employeeID, employeeName, employeeAddress)
        {
            this.employeePosition = employeePosition;
            this.employeeDepartment = employeeDepartment;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine("Employee Position: ", employeePosition);
            Console.WriteLine("Employee Name: ", employeeDepartment);
        }

        public override void CalculateSalary(int workingHours)
        {
            Console.WriteLine(250 + workingHours * 10.80);
        }

        public override void GetDepartment()
        {
            Console.WriteLine(employeeDepartment);
        }
    }
}
