using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var nodes = new Dictionary<int, Tree>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (!nodes.ContainsKey(input[0]))
                {
                    var child = new Tree(input[1]);
                    nodes[input[1]] = child;
                    nodes[input[0]] = new Tree(input[0], child);
                    child.SetParent(nodes[input[0]]);
                }
                else
                {
                    var child = new Tree(input[1]);
                    nodes[input[1]] = child;
                    child.SetParent(nodes[input[0]]);
                    nodes[input[0]].AddChild(child);
                }
            }
            int p = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());

            var root = nodes.Values.Where(x => x.Parent == null).FirstOrDefault();
            Console.WriteLine();
            Console.WriteLine($"Root: {root.Value}");

            Console.WriteLine();
            Console.WriteLine("Print tree");
            Tree.Print(root);

            Console.WriteLine();
            Console.WriteLine($"Leaves: {string.Join(", ", nodes.Values.Where(x => x.Children.Count == 0).Select(x => x.Value).OrderBy(x => x))}");

            Console.WriteLine();
            Console.WriteLine($"Middle nodes: {string.Join(", ", nodes.Values.Where(x => x.Children.Count != 0 && x.Parent != null).Select(x => x.Value).OrderBy(x => x))}");

            Console.WriteLine();
            currentPath.Add(root);
            GetLongestPath(root);
            Console.WriteLine($"Deepest node: {longestPath.Select(x => x.Value).ToList().Last()}");

            Console.WriteLine();
            Console.WriteLine($"Longest path: {string.Join(" ", longestPath.Select(x => x.Value).ToList())}");

            currentPath = new List<Tree> { root };
            GetSumPaths(root, root.Value, p);
            Console.WriteLine();
            Console.WriteLine($"Paths with sum {p}:");
            Console.WriteLine($"{string.Join(Environment.NewLine, sumPaths.Select(x => string.Join(" ", x.Select(a => a.Value))))}");

            Console.WriteLine();
            Console.WriteLine($"SubTrees with sum {s}:");
            GetSumSubTrees(root, s);
            sumSubTrees.ForEach(x => { Tree.Print(x); Console.WriteLine(); });
        }

        static List<Tree> longestPath = new List<Tree>();
        static List<Tree> currentPath = new List<Tree>();
        static List<List<Tree>> sumPaths = new List<List<Tree>>();
        static void GetLongestPath(Tree node)
        {
            if (currentPath.Count > longestPath.Count)
            {
                longestPath = currentPath.ToList();
            }
            foreach (var child in node.Children)
            {
                currentPath.Add(child);
                GetLongestPath(child);
                currentPath.Remove(child);
            }
        }

        static void GetSumPaths(Tree node, int currentSum, int sum)
        {
            if (currentSum == sum)
            {
                sumPaths.Add(currentPath.ToList());
                return;
            }
            foreach (var child in node.Children)
            {
                currentPath.Add(child);
                GetSumPaths(child, currentSum + child.Value, sum);
                currentPath.Remove(child);
            }
        }

        static int tempSum = 0;
        static List<Tree> sumSubTrees = new List<Tree>();
        static void GetSubTreeSum(Tree node)
        {
            tempSum += node.Value;
            foreach (var child in node.Children)
            {
                GetSubTreeSum(child);
            }
        }

        static void GetSumSubTrees(Tree node, int sum)
        {
            tempSum = 0;
            GetSubTreeSum(node);
            if (tempSum == sum)
            {
                sumSubTrees.Add(node);
            }
            foreach (var child in node.Children)
            {
                GetSumSubTrees(child, sum);
            }
        }
    }
}
