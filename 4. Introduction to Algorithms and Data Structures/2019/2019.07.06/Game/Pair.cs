using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Pair
    {
        public int First { get; set; }
        public int Last { get; set; }

        public bool Summed { get;  set; }

        public Pair(int first, int last, bool summed = false)
        {
            this.First = first;
            this.Last = last;
            this.Summed = summed;
        }

        public override string ToString()
        {
            return $"({this.First},{this.Last})";
        }

        public int Difference()
        {
            return Math.Abs(this.First - this.Last);
        }
    }
}
