using MiniORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.ORMApp.Data
{
    [Entity(TableName = "Employees")]
    class Employee
    {
        [Id]
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [Column(ColumnName = "FirstName")]
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        [Column(ColumnName = "MiddleName")]
        private string middleName;

        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }

        [Column(ColumnName = "LastName")]
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        [Column(ColumnName = "IsEmployed")]
        private int isEmployed;

        public int IsEmployed
        {
            get { return isEmployed; }
            set { isEmployed = value; }
        }

        [Column(ColumnName = "DepartmentId")]

        private int departmentId;

        public int DepartmentId
        {
            get { return departmentId; }
            set { departmentId = value; }
        }
        public Employee
            (string firstName, string middleName, string lastName, int isEmployed, int departmentId)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.IsEmployed = isEmployed;
            this.DepartmentId = departmentId;
        }
    }
}
