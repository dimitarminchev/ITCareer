using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomList
{
    public class RandomList : ArrayList
    {
        private Random rnd;

        public object RandomString()
        {
            int element = rnd.Next(0, data.Count - 1);
            string str = data[element];
            data.Remove(str);
            return str;
        }
    }
}
