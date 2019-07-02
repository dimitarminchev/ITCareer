using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26
{
    // Елемент от списъка
    public class ListNode<T>
    {
        public T Value { get; set; }
        public ListNode<T> Prev { get; set; }
        public ListNode<T> Next { get; set; }
        public ListNode(T Value)
        {
            this.Value = Value;
            this.Next = null;
            this.Prev = null;
        }
    }

}
