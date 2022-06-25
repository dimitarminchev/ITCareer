namespace LinkedStack
{
    /// <summary>
    /// Един възел
    /// </summary>
    public class Node<T>
    {
        /// <summary>
        /// Стойност на възела
        /// </summary>
        public T Value { get; set; }

        /// <summary>
        /// Следващ възел
        /// </summary>
        public Node<T> Next { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        public Node(T value, Node<T> next = null)
        {
            this.Value = value;
            this.Next = next;
        }
    }
}
