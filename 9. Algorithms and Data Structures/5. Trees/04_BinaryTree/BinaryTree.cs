public class BinaryTree
{
    public Node Root { get; set; }

    public int Count { get; private set; }


    public BinaryTree()
    {
        Root = null;
        Count = 0;
    }

    public bool Contains(int item)
    {
        if (Root == null) return false;

        Node it = Root;
        while (true)
        {
            if (it == null) return false;
            else if (it.Item.CompareTo(item) == 0) return true;
            else if (it.Item.CompareTo(item) > 0) it = it.Left;
            else if (it.Item.CompareTo(item) < 0) it = it.Right;
        }
    }

    public void Add(int item)
    {
        Node node = new Node(item);

        if (Root == null)
        {
            Root = node;
            return;
        }

        Node it = Root;
        while (true)
        {
            if (it.Left != null && it.Item.CompareTo(item) >= 0) it = it.Left;
            else if (it.Right != null && it.Item.CompareTo(item) < 0) it = it.Right;
            else break;
        }

        if (it.Item.CompareTo(item) >= 0) it.Left = node;
        else if (it.Item.CompareTo(item) < 0) it.Right = node;

        this.Count++;
    }

    // public void Remove(T item);

}


