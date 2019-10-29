using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicList
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

    public class DynamicList
    {
        private Node head;
        private Node tail;

        /// <summary>
        /// Брой
        /// </summary>
        private int count;
        public int Count
        {
            get { return this.count; }
            private set { this.count = value; }
        }

        // Конструктор
        public DynamicList()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }

        /// <summary>
        /// Добавяне
        /// </summary>
        public void Add(object item)
        {
            if (this.head == null)
            {
                // Първи елемент
                Node next = new Node(item);
                this.head = next;
                this.tail = next;
            }
            else
            {
                // Всеки следващ елемент
                Node next = new Node(item, tail);
                this.tail = next;
            }
            this.count++;
        }

        /// <summary>
        /// Връщане на индекс на елемент
        /// </summary>
        public int IndexOf(object item)
        {
            Node current = head;
            int index = 0;
            while (current != null)
            {
                if (current.Element.Equals(item)) return index;
                index++;
                current = current.Next;
            }
            return -1; // Not Found
        }

        /// <summary>
        /// Премахване
        public object Remove(int index)
        {
            Object item = null;
            Node current = head;
            Node previous = null;
            int i = 0;
            while (current != null)
            {
                if (index == i)
                {
                    item = current.Element;
                    previous.Next = current.Next;
                    break;
                }
                i++;
                previous = current;
                current = current.Next;
            }
            return item;
        }

        /// <summary>
        /// Премахване
        /// </summary>
        public int Remove(object item)
        {
            int index = 0;
            Node current = head;
            while (current != null)
            {
                if (current.Element.Equals(item))
                {
                    Remove(index);
                    return index;
                }
                index++;
                current = current.Next;
            }
            return -1; // Not Found
        }

        /// <summary>
        /// Съдържа ли се
        /// </summary>
        public bool Contains(object item)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Element.Equals(item)) return true;
                current = current.Next;
            }
            return false;
        }

        // Достъпване до елементите
        public object this[int index]
        {
            get
            {
                Node current = head;
                int i = 0;
                while (current != null)
                {
                    if (i == index) return current.Element;
                    i++;
                    current = current.Next;
                }
                return null; // Not Found
            }
            set
            {
                Node current = head;
                int i = 0;
                while (current != null)
                {
                    if (i == index)
                    {
                        current.Element = value;
                        break;
                    }
                    i++;
                    current = current.Next;
                }
            }
        }

    }
}
