using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_PrintTree
{
    class Program
    {
        static Dictionary<int, Tree<int>> nodeByValue = new Dictionary<int, Tree<int>>();

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

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n - 1; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                AddEdge(input[0], input[1]);
            }
            Console.Write("Tree leaves: ");
            GetLeaves().OrderBy(x => x.Value).ToList().ForEach(x => Console.Write("{0} ", x.Value));
            Console.WriteLine();
        }
    }
}
