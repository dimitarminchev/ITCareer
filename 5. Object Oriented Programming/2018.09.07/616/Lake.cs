using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _616
{
    public class Lake : IEnumerable<int>
    {
        private int[] rocks;

        public Lake(params int[] rocks)
        {
            this.rocks = rocks;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for(int i = 0; i < rocks.Length; i += 2)
                yield return rocks[i];
            for(int i = rocks.Length - (rocks.Length % 2 == 0 ? 1 : 2); i >= 0; i -= 2)
                yield return rocks[i];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
