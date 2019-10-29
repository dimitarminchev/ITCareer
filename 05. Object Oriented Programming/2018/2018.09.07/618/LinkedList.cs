using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _618
{
    public class LinkedList<T> : IEnumerable<T>
    {
        // Списък
        private Node<T> head;
        private Node<T> tail;
        private int count;
        public int Count 
        {
            get { return count; }
            set { count = value; }
        }

        // Конструктор
        public LinkedList()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }

        // Добавяне на елементи
        public void Add(T item)
        {
            if (count == 0)
            {
                Node<T> current = new Node<T>(item); // Първи
                head = current;
                tail = current;
            }
            else
            {
                Node<T> current = new Node<T>(item, tail); // Следащ
                tail = current;
            }
            count++;
        }

        // Индекса на елемент
        public int IndexOf(T item)
        {
            Node<T> current = head;
            int index = 0;
            while (current != null)
            {
                if (current.Element.Equals(item)) return index;
                index++;
                current = current.Next;
            }
            return -1; // Not Found
        }

        // Премахване
        public T RemoveAt(int index)
        {
            int currentIndex = 0;
            Node<T> current = head;
            Node<T> previous = null;
            while (current != null)
            {
                if (currentIndex == index)
                {
                    if (previous != null) previous.Next = current.Next;
                    else this.head = current.Next;
                    if (current.Next == null) this.tail = previous;
                    count--;
                    return current.Element;
                }
                else
                {
                    previous = current;
                    current = current.Next;
                    currentIndex++;
                }
            }
            return default(T);
        }
        public int Remove(T element)
        {
            int index = this.IndexOf(element);
            T removed = this.RemoveAt(index);
            if (removed == null) return -1;
            else return index;
        }

        // Търсене
        public bool Contains(T item)
        {
            if (IndexOf(item) != -1) return true;
            else return false;
        }

        // Итератор
        public T this[int index]
        {
            get
            {
                int currentIndex = 0;
                Node<T> current = head;
                Node<T> returnNode = null;
                while (current != null)
                {
                    if (currentIndex == index)
                    {
                        returnNode = current;
                        break;
                    }
                    current = current.Next;
                    currentIndex++;
                }
                if (returnNode != null) return returnNode.Element;
                throw new IndexOutOfRangeException();
            }
            set
            {
                int currentIndex = 0;
                Node<T> current = head;
                Node<T> changedNode = null;
                while (current != null)
                {
                    if (currentIndex == index)
                    {
                        changedNode = current;
                        break;
                    }
                    current = current.Next;
                    currentIndex++;
                }
                if (changedNode != null) changedNode.Element = value;
                throw new IndexOutOfRangeException();
            }
        }

        // Нумератор
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            yield return this[i];
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }


}
