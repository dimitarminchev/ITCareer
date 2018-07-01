using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    // Елемент
    public class Node
    {
        // Елемент от списъка
        private object element;
        public object Element
        {
            get { return element; }
            set { element = value; }
        }

        // Следващ елемент от списъка
        private Node next;
        public Node Next
        {
            get { return next; }
            set { next = value; }
        }

        // Конструктор за слеващ елемент
        public Node(object element, Node previous)
        {
            this.element = element;
            previous.next = this;
        }

        // Конструктор за първи елемент
        public Node(object element)
        {
            this.element = element;
            next = null;
        }
    }
}
