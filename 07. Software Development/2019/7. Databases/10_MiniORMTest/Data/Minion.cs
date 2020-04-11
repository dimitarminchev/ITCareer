using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniORM
{
    [Entity(TableName = "minions")]
    class Minion
    {
        [Id]
        private int id;
        public int Id
        {
            get
            {
                return this.id;
            }

            set
            {
                this.id = value;
            }
        }

        [Column(ColumnName = "Name")]
        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        [Column(ColumnName = "Age")]
        private int age;
        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                this.age = value;
            }
        }

        [Column(ColumnName = "TownId")]
        private int townid;
        public int TownId
        {
            get
            {
                return this.townid;
            }

            set
            {
                this.townid = value;
            }
        }

        public Minion(string name, int age, int townid)
        {
            this.Name = name;
            this.Age = age;
            this.TownId = townid;
        }

    }
}