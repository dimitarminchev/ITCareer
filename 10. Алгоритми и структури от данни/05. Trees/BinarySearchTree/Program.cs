namespace BinarySearchTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tree elements: ");
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            BinaryTree<int> binaryTree = new BinaryTree<int>();
            foreach (var element in elements)
            {
                binaryTree.Add(element);
            }

            int elementToFind = int.Parse(Console.ReadLine());
            Queue<int> pathToElement = binaryTree.Find(elementToFind);
            Console.WriteLine("Path to element {0}: {1}", elementToFind, pathToElement != null ? string.Join(" -> ", pathToElement) : "Not Found");
            Console.WriteLine("Tree contains element {0}: {1}", elementToFind, binaryTree.Contains(elementToFind));

            int elementToDelete = int.Parse(Console.ReadLine());
            binaryTree.PrintTree();
            binaryTree.Delete(elementToDelete);
            binaryTree.PrintTree();
        }
    }
}