namespace PrintLeaves
{
    public class Program
    {
        private static Dictionary<int, Tree<int>> nodeByValue = new Dictionary<int, Tree<int>>();

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

        private static List<Tree<int>> GetLeaves()
        {
            List<Tree<int>> leaves = nodeByValue.Values.Where(x => x.Children.Count == 0).ToList();
            return leaves;
        }

        static void Main(string[] args)
        {
            ReadTree();
            Console.WriteLine("Leaves:");
            GetLeaves().OrderBy(x => x.Value).ToList().ForEach(x => Console.Write("{0} ", x.Value));
        }
    }
}