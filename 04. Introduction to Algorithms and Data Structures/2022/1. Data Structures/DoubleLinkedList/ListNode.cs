namespace DoubleLinkedList
{
    /// <summary>
    /// Един възел
    /// </summary>
    public class ListNode<T>
    {
        /// <summary>
        /// Стойност на възела
        /// </summary>
        public T Value { get; private set; }

        /// <summary>
        /// Предишен възел
        /// </summary>
        public ListNode<T> Prev { get; set; }

        /// <summary>
        /// Следващ възел
        /// </summary>
        public ListNode<T> Next { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        public ListNode(T value)
        {
            this.Value = value;
        }
    }

}
