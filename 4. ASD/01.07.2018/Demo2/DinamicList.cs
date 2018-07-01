using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    public class DinamicList
    {
        // Елемент
        public class Node
        {
            // Елемент от списъка
            private object element;
            public object Element
            {
                get { return element;  }
                set { element = value; }
            }
            // Следващ елемент от списъка
            private Node next;
            public object Next
            {
                get { return element; }
                set { element = value; }
            }
            //TODO: Добавете свойства за Element и Next с публични get и set
            public Node(object element, Node prevNode)
            {
                this.element = element;
                prevNode.next = this;
            }
            public Node(object element)
            {
                this.element = element;
                next = null;
            }
        }
        // Списък
        private Node head;
        private Node tail;
        private int count;
        public DynamicList() {…}
        public void Add(object item) { … }
        public object Remove(int index) { … }
        public int Remove(object item) { … }
        public int IndexOf(object item) { … }
        public bool Contains(object item) { … }
        public object this[int index] { …}

    }
}
