namespace DoublyLinkedList
{
    public class ListNode<T>
    {
        public T Value { get; private set; }

        public ListNode<T> Prev { get; set; }

        public ListNode<T> Next { get; set; }

        public ListNode(T value)
        {
            this.Value = value;
        }
    }
}