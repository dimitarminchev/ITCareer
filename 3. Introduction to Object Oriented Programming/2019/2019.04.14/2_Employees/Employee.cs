using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Employees
{
    class Employee
    {
        // Име
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Заплата
        private double salary;

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        // Длъжност
        private string position;

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        // Отдел
        private string department;

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        // Електронна поща 
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        // Възраст
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }


    }
}
