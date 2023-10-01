namespace BinarySearchTree
{
    public class BinaryTree<T> where T : IComparable
    {
        public TreeNode<T> Root { get; set; }

        public class TreeNode<T>
        {
            public T Value { get; set; }
            public TreeNode<T> Left { get; set; }
            public TreeNode<T> Right { get; set; }

            public TreeNode(T value)
            {
                this.Value = value;
            }
        }
        
        public BinaryTree()
        {
            Root = null;
        }

        public BinaryTree(T rootValue)
        {
            Root = new TreeNode<T>(rootValue);
        }

        public void Add(T valueToAdd)
        {
            if (Root == null)
            {
                Root = new TreeNode<T>(valueToAdd);
                return;
            }
            Add(Root, valueToAdd);
        }

        public bool Contains(T value)
        {
            if (Root == null) return false;

            TreeNode<T> currentNode = Root;
            bool found = false;
            while (currentNode != null)
            {
                if (currentNode.Value.CompareTo(value) > 0)
                {
                    currentNode = currentNode.Left;
                }
                else if (currentNode.Value.CompareTo(value) < 0)
                {
                    currentNode = currentNode.Right;
                }
                else
                {
                    found = true;
                    break;
                }
            }

            return found;
        }

        public Queue<T> Find(T valueToFind)
        {
            if (Root == null) return null;
            Queue<TreeNode<T>> path = new Queue<TreeNode<T>>();
            path.Enqueue(Root);
            Find(path, valueToFind);
            if (path.Contains(null)) return null;

            Queue<T> pathWithValues = new Queue<T>();
            foreach (var item in path)
            {
                pathWithValues.Enqueue(item.Value);
            }
            return pathWithValues;
        }

        public void PrintTree()
        {
            PrintTree(Root, 0);
        }

        private void PrintTree(TreeNode<T> currentNode, int offset)
        {
            if (currentNode == null) return;
            Console.WriteLine("{0}{1}", new string(' ', 2 * offset), currentNode.Value);
            PrintTree(currentNode.Left, offset + 1);
            PrintTree(currentNode.Right, offset + 1);
        }

        public void Delete(T element)
        {
            TreeNode<T> previousNode = null;
            bool previousDirectionIsLeft = false;
            TreeNode<T> currentNode = Root;
            while (currentNode != null)
            {
                if (currentNode.Value.CompareTo(element) > 0)
                {
                    previousNode = currentNode;
                    previousDirectionIsLeft = true;
                    currentNode = currentNode.Left;
                }
                else if (currentNode.Value.CompareTo(element) < 0)
                {
                    previousNode = currentNode;
                    previousDirectionIsLeft = false;
                    currentNode = currentNode.Right;
                }
                else
                {
                    if (currentNode.Left == null && currentNode.Right == null)
                    {
                        currentNode = null;
                        return;
                    }
                    else if (currentNode.Right == null)
                    {
                        if (previousDirectionIsLeft)
                        {
                            previousNode.Left = currentNode.Left;
                            return;
                        }
                        else
                        {
                            previousNode.Right = currentNode.Left;
                            return;
                        }
                    }
                    else if (currentNode.Right.Left == null)
                    {
                        if (previousDirectionIsLeft)
                        {
                            previousNode.Left = currentNode.Right;
                            currentNode.Right.Left = currentNode.Left;
                            currentNode = currentNode.Right;
                            return;
                        }
                        else
                        {
                            previousNode.Right = currentNode.Right;
                            currentNode.Right.Left = currentNode.Left;
                            currentNode = currentNode.Right;
                            return;
                        }
                    }
                    else
                    {
                        TreeNode<T> previousToSmallestNode = currentNode.Right;
                        TreeNode<T> smallestNode = currentNode.Right.Left;
                        while (true)
                        {
                            if (smallestNode.Left == null)
                            {
                                break;
                            }
                            else
                            {
                                previousToSmallestNode = smallestNode;
                                smallestNode = smallestNode.Left;
                            }
                        }
                        previousToSmallestNode.Left = smallestNode.Right;
                        smallestNode.Left = currentNode.Left;
                        smallestNode.Right = currentNode.Right;
                        currentNode = smallestNode;
                        if (previousDirectionIsLeft)
                        {
                            previousNode.Left = currentNode;
                        }
                        else previousNode.Right = currentNode;
                    }
                }
            }
        }

        private void Find(Queue<TreeNode<T>> path, T valueToFind)
        {
            TreeNode<T> lastNode = path.Last();
            if (lastNode == null) return;
            else if (lastNode.Value.CompareTo(valueToFind) > 0)
            {
                path.Enqueue(lastNode.Left);
                Find(path, valueToFind);
            }
            else if (lastNode.Value.CompareTo(valueToFind) < 0)
            {
                path.Enqueue(lastNode.Right);
                Find(path, valueToFind);
            }
            else
            {
                return;
            }
        }

        private void Add(TreeNode<T> currentNode, T valueToAdd)
        {
            if (currentNode.Value.CompareTo(valueToAdd) < 0)
            {
                if (currentNode.Right == null)
                {
                    currentNode.Right = new TreeNode<T>(valueToAdd);
                }
                else Add(currentNode.Right, valueToAdd);
            }
            else if (currentNode.Value.CompareTo(valueToAdd) > 0)
            {
                if (currentNode.Left == null)
                {
                    currentNode.Left = new TreeNode<T>(valueToAdd);
                }
                else Add(currentNode.Left, valueToAdd);
            }
        }
    }
}
