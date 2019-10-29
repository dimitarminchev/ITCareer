using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_RawData
{
    class Tovar
    {
        private int weight;

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public Tovar(int weight, string type)
        {
            this.weight = weight;
            this.type = type;
        }
    }
}
