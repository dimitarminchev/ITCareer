using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _04_RandomList
{
    public class RandomList : ArrayList
    {
        private Random random = new Random();

        public object RandomObject()
        {
            var index = random.Next(0, base.Count - 1);
            object element = base[index];
            base.Remove(element);
            return element;
        }
    }
}
