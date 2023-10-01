namespace DeepestNode
{
    public class Program
    {
        private static Dictionary<int, Tree<int>> nodeByValue = new Dictionary<int, Tree<int>>();

        private static int maxDepth = 0;

        private static Tree<int> deepestNode;

        private static Tree<int> GetTreeNodeByValue(int value)
        {
            if (!nodeByValue.ContainsKey(value))
            {
                nodeByValue[value] = new Tree<int>(value, null);
            }
            return nodeByValue[value];
        }

        private static void AddEdge(int parent, int child)
        {
            Tree<int> parentNode = GetTreeNodeByValue(parent);
            Tree<int> childNode = GetTreeNodeByValue(child);
            parentNode.AddChild(childNode);
            childNode.SetParent(parentNode);
        }

        private static void ReadTree()
        {
            int nodeCount = int.Parse(Console.ReadLine());
            for (int i = 1; i < nodeCount; i++)
            {
                string[] edge = Console.ReadLine().Split().ToArray();
                AddEdge(int.Parse(edge[0]), int.Parse(edge[1]));
            }
        }

        private static Tree<int> GetRoot()
        {
            Tree<int> root = nodeByValue.Values.Where(x => x.Parent == null).FirstOrDefault();
            return root;
        }

        private static void FindDeepestNode(Tree<int> node, int currentDepth)
        {
            if (currentDepth > maxDepth)
            {
                maxDepth = currentDepth;
                deepestNode = node;
            }
            foreach (var child in node.Children)
            {
                FindDeepestNode(child, currentDepth + 1);
            }
        }

        static void Main(string[] args)
        {
            ReadTree();
            maxDepth = 0;
            deepestNode = GetRoot();
            FindDeepestNode(GetRoot(), 0);
            Console.WriteLine("Deepest node: {0}", deepestNode.Value);
        }
    }
}