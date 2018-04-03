using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4
{
    /// <summary>
    /// Служител
    /// </summary>
    class Employee
    {
        // име
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        // заплата
        private double salary;
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        // длъжност
        private string job;
        public string Job
        {
            get { return job; }
            set { job = value; }
        }
        // отдел
        private string department;
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        // електронна поща
        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        // възраст
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}
