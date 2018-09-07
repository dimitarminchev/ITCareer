using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _618
{
    // Елемент
    public class Node<T>
    {
        // Елемент от списъка
        private T element;
        public T Element
        {
            get { return element; }
            set { element = value; }
        }

        // Следващ елемент от списъка
        private Node<T> next;
        public Node<T> Next
        {
            get { return next; }
            set { next = value; }
        }

        // Конструктор за слеващ елемент
        public Node(T element, Node<T> previous)
        {
            this.element = element;
            previous.next = this;
        }

        // Конструктор за първи елемент
        public Node(T element)
        {
            this.element = element;
            next = null;
        }
    }
}
