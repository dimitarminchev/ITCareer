namespace LongestPath
{
    public class Program
    {
        static Dictionary<int, Tree<int>> nodeByValue = new Dictionary<int, Tree<int>>();
        static List<Tree<int>> longestPath = new List<Tree<int>>();
        static List<Tree<int>> currentPath = new List<Tree<int>>();

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

        static void FindLongestPath(Tree<int> node)
        {
            if (currentPath.Count > longestPath.Count)
            {
                longestPath = currentPath.ToArray().ToList();
            }
            foreach (var child in node.Children)
            {
                currentPath.Add(child);
                FindLongestPath(child);
                currentPath.Remove(child);
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
            Tree<int> root = GetRoot();
            currentPath.Add(root);
            longestPath.Add(root);
            FindLongestPath(root);
            Console.Write("Longest path: ");
            longestPath.ForEach(x => Console.Write(x.Value + " "));
            Console.WriteLine();
        }
    }
}