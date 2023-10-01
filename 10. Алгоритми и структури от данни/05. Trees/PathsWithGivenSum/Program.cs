namespace PathsWithGivenSum
{
    public class Program
    {
        private static Dictionary<int, Tree<int>> nodeByValue = new Dictionary<int, Tree<int>>();
       
        private static List<List<Tree<int>>> allPaths = new List<List<Tree<int>>>();
       
        private static List<Tree<int>> currentPath = new List<Tree<int>>();

        private  static Tree<int> GetTreeNodeByValue(int value)
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

        private static void FindPathsWithGivenSum(Tree<int> node, int currentSum, int sumToReach)
        {
            if (currentSum == sumToReach)
            {
                allPaths.Add(currentPath.ToArray().ToList());
                return;
            }
            foreach (var child in node.Children)
            {
                currentPath.Add(child);
                FindPathsWithGivenSum(child, currentSum + child.Value, sumToReach);
                currentPath.Remove(child);
            }
        }

        static void Main(string[] args)
        {
            ReadTree();
            int sumToReach = int.Parse(Console.ReadLine());
            Console.WriteLine("Paths with sum of {0}: ", sumToReach);
            Tree<int> root = GetRoot();
            currentPath.Add(root);
            FindPathsWithGivenSum(root, root.Value, sumToReach);
            allPaths.ForEach(path => Console.WriteLine(string.Join(" => ", path.Select(x => x.Value).ToArray())));
        }
    }
}