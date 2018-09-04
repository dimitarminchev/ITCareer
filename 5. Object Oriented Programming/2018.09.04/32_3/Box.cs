using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_3
{
    public class Box<T>
    {
        private T item;

        public T Item
        {
            get { return item; }
            set { item = value; }
        }
        public Box(T item = default(T))
        {
            this.Item = item;
        }



        public override string ToString()
        {
            string temp = null, type = null;
            type = item.GetType().ToString();
            temp += item.ToString();
            return $"{type}: {temp}";
        }
    }
}
