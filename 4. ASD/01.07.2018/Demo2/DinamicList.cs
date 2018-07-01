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

        // Добавяне на елементи
        public void Add(object item)
        {
            if (count == 0) 
            {
                Node current = new Node(item); // Първи
                head = current;
                tail = current;
            }
            else 
            {
                Node current = new Node(item, tail); // Следащ
                tail = current;
            }
            count++;
        }

        // Индекса на елемент
        public int IndexOf(object item)
        {
            Node current = head;
            int index = 0;
            while(true)
            {
                if (current == null) break;
                if (current.Element.Equals(item)) return index;
                if (current == tail) break;
                current = current.Next;
                index++;
            }
            return -1; // Not Found
        }

        // Премахване
        public object Remove(int index)
        {
            int currentIndex = 0;
            Node current = head;
            Node previous = null;
            while (current != null)
            {
                if (currentIndex == index) 
                {
                    if (previous != null) previous.Next = current.Next;
                    else this.head = current.Next;
                    count--;
                    return current.Element;
                }
                previous = current;
                currentIndex++;
                current = current.Next;
            }
            return null;
        }

        // TODO
        // public int Remove(object item) { … }
        // public bool Contains(object item) { … }
        // public object this[int index] { … }

    }
}
