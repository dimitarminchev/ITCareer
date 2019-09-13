using System.Collections;
using System.Collections.Generic;

namespace _6._1._6_Froggy
{
    class Lake : IEnumerable<int>
    {
        private int[] rocks;
        public Lake(int[] rocks)
        {
            this.rocks = rocks;
        }
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i <rocks.Length; i+=2) yield return rocks[i];
            for (int i = rocks.Length - (rocks.Length % 2 == 0 ? 1 : 2); i >= 0; i -= 2) yield return rocks[i];
           
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
