namespace BinaryTree
{
    /// <summary>
    /// Единичен възел на двоичното дърво
    /// </summary>
    public class BinaryNode<T>
    {
        public T Item { get; set; }

        public BinaryNode<T> Left { get; set; }

        public BinaryNode<T> Right { get; set; }

        public BinaryNode(T item) 
        { 
            this.Item = item; 
        }
    }
}