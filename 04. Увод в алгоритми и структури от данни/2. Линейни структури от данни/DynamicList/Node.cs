namespace DynamicList
{
    class Node
    {
        private object element;
        public object Element
        {
            get { return this.element; }
            set { this.element = value; }
        }

        private Node next;
        public Node Next
        {
            get { return this.next; }
            set { this.next = value; }
        }

        public Node(object element, Node prevNode)
        {
            this.element = element;
            prevNode.next = this;
        }

        public Node(object element)
        {
            this.element = element;
            next = null;
        }
    }
}