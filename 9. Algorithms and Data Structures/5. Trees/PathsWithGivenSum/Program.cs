using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_PathsWithGivenSum
{
    class Program
    {
        static Dictionary<int, Tree<int>> nodeByValue = new Dictionary<int, Tree<int>>();
        static List<List<Tree<int>>> allPaths = new List<List<Tree<int>>>();
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

        static void FindPathsWithGivenSum(Tree<int> node, int currentSum, int sumToReach)
        {
            if(currentSum == sumToReach)
            {
                allPaths.Add(currentPath.ToArray().ToList());
                return;
            }
            foreach(var child in node.Children)
            {
                currentPath.Add(child);
                FindPathsWithGivenSum(child, currentSum + child.Value, sumToReach);
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
            int sumToReach = int.Parse(Console.ReadLine());
            Tree<int> root = GetRoot();
            currentPath.Add(root);
            FindPathsWithGivenSum(root, root.Value, sumToReach);
            Console.WriteLine("Paths with sum of {0}: ", sumToReach);
            foreach (var path in allPaths)
            {
                path.ForEach(x => Console.Write(x.Value + " "));
                Console.WriteLine();
            }
        }
    }
}
