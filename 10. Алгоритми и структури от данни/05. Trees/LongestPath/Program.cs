namespace LongestPath
{
    public class Program
    {
        private static Dictionary<int, Tree<int>> nodeByValue = new Dictionary<int, Tree<int>>();

        private static List<Tree<int>> longestPath = new List<Tree<int>>();

        private static List<Tree<int>> currentPath = new List<Tree<int>>();

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

        private static void FindLongestPath(Tree<int> node)
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
            ReadTree();
            Tree<int> root = GetRoot();
            currentPath.Add(root);
            longestPath.Add(root);
            FindLongestPath(root);

            Console.WriteLine("The Longest Path:");
            longestPath.ForEach(x => Console.Write(x.Value + " "));
            Console.WriteLine();
        }
    }
}