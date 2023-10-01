namespace BinarySearchTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Binary Tree
            BinaryTree<int> binaryTree = new BinaryTree<int>();

            // Tree nodes: 17, 9, 6, 12, 19, 25
            int[] nodes = new int[] { 17, 9, 6, 12, 19, 25 };
            foreach (var node in nodes)
            {
                binaryTree.Add(node);
            }

            // Node to Find = 12
            int nodeToFind = 12;
            Queue<int> pathToNode = binaryTree.Find(nodeToFind);
            Console.WriteLine("Path to Node {0}: {1}", nodeToFind, pathToNode != null ? string.Join(" -> ", pathToNode) : "Not Found");
            Console.WriteLine("Tree contains node {0}: {1}", nodeToFind, binaryTree.Contains(nodeToFind));

            // Node to Delete = 19
            int nodeToDelete = 19;
            Console.WriteLine("Tree before delete node {0}:", nodeToDelete);
            binaryTree.PrintTree();
            binaryTree.Delete(nodeToDelete);
            Console.WriteLine("Tree after delete node {0}:", nodeToDelete);
            binaryTree.PrintTree();
        }
    }
}