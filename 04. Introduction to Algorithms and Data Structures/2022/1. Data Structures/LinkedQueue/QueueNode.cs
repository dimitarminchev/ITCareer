namespace LinkedQueue
{
    /// <summary>
    /// Един възел
    /// </summary>
    public class QueueNode<T>
    {
        // Стойност на елемент
        public T Value { get; private set; }

        // Следващ елемент
        public QueueNode<T> Next { get; set; }

        // Предишен елемент
        public QueueNode<T> Prev { get; set; }

        // Конструктор
        public QueueNode(T value)
        {
            this.Value = value;
        }
    }
}
