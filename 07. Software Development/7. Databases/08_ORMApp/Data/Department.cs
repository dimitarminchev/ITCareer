using MiniORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.ORMApp.Data
{
    [Entity(TableName = "departments")]
    class Department
    {
        [Id]
        private int id;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        [Column(ColumnName = "Name")]
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Department(string name)
        {
            this.Name = name;
        }
    }
}
