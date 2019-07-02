using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28
{
    public class Node<T>
    {
        // Елемент
        public T Value { get; set; }

        // Следващ елемент
        public Node<T> NextNode { get; set; }

        // Конструктор
        public Node(T value, Node<T> nextNode = null)
        {
            this.Value = value;
            this.NextNode = nextNode;
        }
    }
}
