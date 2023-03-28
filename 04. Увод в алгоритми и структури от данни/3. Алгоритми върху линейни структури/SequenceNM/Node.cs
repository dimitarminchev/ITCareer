namespace SequenceNM
{
    public class Node
    {
        public int Element { get; set; }

        public Node Previous { get; set; }

        public Node(int e, Node p)
        {
            this.Element = e;
            this.Previous = p;
        }
    }
}