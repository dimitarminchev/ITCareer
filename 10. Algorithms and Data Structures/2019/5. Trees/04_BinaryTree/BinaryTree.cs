public class BinaryTree
{
    public BinaryNode Root { get; set; }

    public int Count { get; private set; }


    public BinaryTree()
    {
        Root = null;
        Count = 0;
    }

    public bool Contains(int item)
    {
        if (Root == null) return false;

        BinaryNode it = Root;
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
        BinaryNode node = new BinaryNode(item);

        if (Root == null)
        {
            Root = node;
            return;
        }

        BinaryNode it = Root;
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
}


