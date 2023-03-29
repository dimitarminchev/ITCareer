using System.Collections;

namespace LinkedList
{
    public class LinkedList<T> : IEnumerable<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public int Count { get; private set; }

        public LinkedList()
        {
            head = null;
            tail = null;
            Count = 0;
        }

        public void Add(T item)
        {
            if (head == null)
            {
                Node<T> next = new Node<T>(item);
                head = next;
                tail = next;
            }
            else
            {
                Node<T> next = new Node<T>(item, tail);
                tail = next;
            }
            Count++;
        }

        public bool Remove(T item)
        {
            int index = 0;
            Node<T> current = head;

            if (EqualityComparer<T>.Default.Equals(head.Element, item))
            {
                head = head.Next;
                Count--;
                return true;
            }

            while (current != null)
            {
                if (current.Element.Equals(item))
                {
                    Remove(index);
                    Count--;
                    return true;
                }
                index++;
                current = current.Next;
            }
            return false; // Not Found
        }

        public object Remove(int index)
        {
            object item = null;
            Node<T> current = head;
            Node<T> previous = current;
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

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> node = head;
            while (node != null)
            {
                yield return node.Element;
                node = node.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}