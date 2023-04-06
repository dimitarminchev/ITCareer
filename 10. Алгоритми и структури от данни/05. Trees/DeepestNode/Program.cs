namespace DeepestNode
{
    public class Program
    {
        static Dictionary<int, Tree<int>> nodeByValue = new Dictionary<int, Tree<int>>();
        static int maxDepth = 0;
        static Tree<int> deepestNode;

        static Tree<int> GetTreeNodeByValue(int value)
        {
            if (!nodeByValue.ContainsKey(value))
            {
                nodeByValue[value] = new Tree<int>(value, null);
            }
            return nodeByValue[value];
        }

        static void AddEdge(int parent, int child)
        {
            Tree<int> parentNode = GetTreeNodeByValue(parent);
            Tree<int> childNode = GetTreeNodeByValue(child);
            parentNode.AddChild(childNode);
            childNode.SetParent(parentNode);
        }

        static List<Tree<int>> GetLeaves()
        {
            List<Tree<int>> leaves = nodeByValue.Values.Where(x => x.Children.Count == 0).ToList();
            return leaves;
        }

        static Tree<int> GetRoot()
        {
            Tree<int> root = nodeByValue.Values.Where(x => x.Parent == null).FirstOrDefault();
            return root;
        }

        static List<Tree<int>> GetMiddleNodes()
        {
            List<Tree<int>> middleNodes = nodeByValue.Values.Where(x => x.Children.Count > 0 && x.Parent != null).ToList();
            return middleNodes;
        }

        static void FindDeepestNode(Tree<int> node, int currentDepth)
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
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n - 1; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                AddEdge(input[0], input[1]);
            }
            maxDepth = 0;
            deepestNode = GetRoot();
            FindDeepestNode(GetRoot(), 0);
            Console.WriteLine("Deepest node: {0}", deepestNode.Value);
        }
    }
}