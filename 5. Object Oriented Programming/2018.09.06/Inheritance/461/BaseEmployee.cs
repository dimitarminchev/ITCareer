using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _461
{
    public class BaseEmployee
    {
        public string employeeID { get; private set; }
        public string employeeName { get; private set; }
        public string employeeAddress { get; private set; }

        public BaseEmployee(string employeeID, string employeeName, string employeeAddress)
        {
            this.employeeID = employeeID;
            this.employeeName = employeeName;
            this.employeeAddress = employeeAddress;
        }

        public virtual void Show()
        {
            Console.WriteLine("Employee ID: ", employeeID);
            Console.WriteLine("Employee Name: ", employeeName);
            Console.WriteLine("Employee Address: ", employeeAddress);
        }

        public virtual void CalculateSalary(int workingHours)
        {
        }

        public virtual void GetDepartment()
        {
        }
    }
}

