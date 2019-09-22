using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _73_GraphCycle
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, List<char>> graph = new Dictionary<char, List<char>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                if (!graph.ContainsKey(input[0]))
                {
                    graph.Add(input[0], new List<char>());
                }
                if (!graph.ContainsKey(input[2]))
                {
                    graph.Add(input[2], new List<char>());
                }
                graph[input[0]].Add(input[2]);
                graph[input[2]].Add(input[0]);
            }

            foreach (var node in graph)
            {
                try
                {
                    IsGraphAcyclic(node.Key, default(char), new List<char>(), graph);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("Graph is acyclic: No");
                    return;
                }
            }
            Console.WriteLine("Graph is acyclic: Yes");
        }

        static void IsGraphAcyclic(char node, char parentNode, List<char> visitedNodes, Dictionary<char, List<char>> graph)
        {
            if (visitedNodes.Contains(node))
            {
                throw new ArgumentException("Error: A cycle was found");
            }
            if (!visitedNodes.Contains(node))
            {
                visitedNodes.Add(node);
                foreach (var neighboringNode in graph[node])
                {
                    if (neighboringNode != parentNode)
                    {
                        IsGraphAcyclic(neighboringNode, node, visitedNodes, graph);
                    }
                }
                visitedNodes.Remove(node);
            }
        }
    }
}
