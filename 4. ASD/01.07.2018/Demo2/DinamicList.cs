using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    public class DinamicList
    {
        // Списък
        private Node head;
        private Node tail;
        private int count;
        public int Count // O(1)
        {
            get { return count; }
            set { count = value;  }
        }

        // public void Add(object item) { … }

        /*
          public DynamicList() {…}
         
         public object Remove(int index) { … }
         public int Remove(object item) { … }
         public int IndexOf(object item) { … }
         public bool Contains(object item) { … }
         public object this[int index] { …}
          */

    }
}
