using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedStack
{
    public class LinkedStack<T>
    {
        private Node<T> firstNode;
        public int Count { get; private set; }
        public void Push(T element)
        {
            if(Count==0)
            {
                this.firstNode = new Node<T>(element);
            }
            else
            {
                Node<T>nextNode = this.firstNode;
                this.firstNode = new Node<T>(element, nextNode);
            }
            Count++;
        }
        public T Pop()
        {
            Node<T> fNode = this.firstNode;
            this.firstNode = firstNode.NextNode;
            return fNode.Value;
        }
        public T[] ToArray()
        {
            T[] result= new T[Count];
            Node<T> current = this.firstNode;
            int ind = 0;
            while(current!=null)
            {
                result[ind] = current.Value;
                current = current.NextNode;
                ind++;
            }
            return result.Reverse().ToArray();
        }
        private class Node<T>
        {
            public T Value { get; set; }
            public Node<T> NextNode { get; set; }
            public Node(T value, Node<T> nextNode = null)
            {
                this.Value = value;
                this.NextNode = nextNode;
            }
        }
    }
}
