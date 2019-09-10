using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Scale
{
    public class Scale<T> where T : IComparable<T>
    {
        private T left;
        private T right;

        public Scale(T left, T right)
        {
            this.left = left;
            this.right = right;
        }

        public T GetHavier()
        {
            if (left.CompareTo(right) > 0)  return left;
            else if (left.CompareTo(right) < 0) return right; 
            return default(T);
        }
    }

}
