using System.Collections;

namespace DynamicList
{
    /// <summary>
    /// Възел от списъка
    /// </summary>
    public class Node
    {
        private object element;

        /// <summary>
        /// Елемент
        /// </summary>
        public object Element
        {
            get { return element; }
            set { element = value; }
        }

        private Node next;

        /// <summary>
        /// Следващ елемент
        /// </summary>
        public Node Next
        {
            get { return next; }
            set { next = value; }
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

    /// <summary>
    /// Динамичен списък
    /// </summary>
    public class DynamicList : IEnumerable
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

        /// <summary>
        /// Конструктор
        /// </summary>
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
        /// </summary>
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

        /// <summary>
        /// Достъпване до елементите
        /// </summary>
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

        public IEnumerator GetEnumerator()
        {
            Node current = head;
            while (current != null)
            {
                yield return current.Element;
                current = current.Next;
            }
        }

    }
}
