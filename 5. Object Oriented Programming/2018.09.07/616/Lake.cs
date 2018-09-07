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
        private List<int> rocks;

        public Lake(params int[] rocks)
        {
            this.rocks = new List<int>(rocks);
        }

        public IEnumerator<int> GetEnumerator()
        {
            if (this.rocks.Count % 2 == 0)
            {
                // odd
                for (int i = 0; i < this.rocks.Count; i += 2)
                    yield return this.rocks[i];

                // even
                for (int i = this.rocks.Count - 1; i >= 0; i -= 2)
                    yield return this.rocks[i];
            }
            else
            {
                // odd
                for (int i = 0; i <= this.rocks.Count - 1; i += 2)
                    yield return this.rocks[i];

                // even
                for (int i = this.rocks.Count - 2; i >= 0; i -= 2)
                    yield return this.rocks[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
