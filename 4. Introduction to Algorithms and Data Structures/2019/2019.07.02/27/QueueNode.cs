using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27
{
    public class QueueNode<T>
    {
        // Стойност на елемент
        public T Value { get; private set; }

        // Следващ елемент
        public QueueNode<T> NextNode { get; set; }

        // Предишен елемент
        public QueueNode<T> PrevNode { get; set; }

        // Конструктиор
        public QueueNode(T value)
        {
            this.Value = value;
        }
    }
}
