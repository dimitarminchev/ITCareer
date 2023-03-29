namespace LinkedList
{
    public class Node<T>
    {
        private T element;

        public T Element
        {
            get { return this.element; }
            set { this.element = value; }
        }

        private Node<T> next;

        public Node<T> Next
        {
            get { return this.next; }
            set { this.next = value; }
        }

        public Node(T element, Node<T> prevNode)
        {
            this.element = element;
            prevNode.next = this;
        }

        public Node(T element)
        {
            this.element = element;
            next = null;
        }
    }
}