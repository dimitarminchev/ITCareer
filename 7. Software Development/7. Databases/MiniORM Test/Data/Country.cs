using MiniORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniORM_Test
{
    [Entity(TableName = "countries")]
    class Country
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


        public Country(string name)
        {
            this.Name = name;
        }
    }
}
