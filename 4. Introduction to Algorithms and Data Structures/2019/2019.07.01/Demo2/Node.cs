using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    public class Node
    {
        /// <summary>
        /// Елемент
        /// </summary>
        private object element;
        public object Element
        {
            get { return this.element; }
            set { this.element = value; }
        }

        /// <summary>
        /// Следващ елемент
        /// </summary>
        private Node next;
        public Node Next
        {
            get { return this.next; }
            set { this.next = value; }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        public Node(object element, Node prevNode)
        {
            this.element = element;
            prevNode.next = this;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        public Node(object element)
        {
            this.element = element;
            next = null;
        }

    }
}
