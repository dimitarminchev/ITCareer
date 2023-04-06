namespace BinaryTree
{
    // Структура двоично дърво
    public class BinaryTree
    {
        public BinaryNode Root { get; set; }
        public int Count { get; private set; }
        public BinaryTree()
        {
            this.Root = null;
            this.Count = 0;
        }
        public void Add(int item)
        {
            var node = new BinaryNode(item);
            if (this.Root == null)
            {
                this.Root = node;
                return;
            }
            BinaryNode it = this.Root;
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

        public bool Contains(int Item)
        {
            if (this.Root == null) return false;
            BinaryNode it = this.Root;
            while (true)
            {
                if (it == null) return false;
                else if (it.Item.CompareTo(Item) == 0) return true;
                else if (it.Item.CompareTo(Item) > 0) it = it.Left;
                else if (it.Item.CompareTo(Item) < 0) it = it.Right;
            }
        }
    }
}
