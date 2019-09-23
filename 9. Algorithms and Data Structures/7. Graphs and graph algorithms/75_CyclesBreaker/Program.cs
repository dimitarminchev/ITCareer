using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _75_CyclesBreaker
{
    class Program
    {
        static void Main(string[] args)
        {
            var graph = new Dictionary<string, List<string>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input =
                     Console.ReadLine()
                    .Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                graph.Add(input[0], new List<string>());
                for (int j = 1; j < input.Length; j++)
                {
                    graph[input[0]].Add(input[j]);
                }
            }
            var sortedGraph = new Dictionary<string, List<string>>();
            foreach (var keyValuePair in graph.OrderBy(x => x.Key))
            {
                sortedGraph.Add(keyValuePair.Key, keyValuePair.Value.OrderBy(x => x).ToList());
            }

            var removedEdges = new List<Tuple<string, string>>();
            RemoveCycles(sortedGraph, removedEdges);
            Console.WriteLine("Number of removed edges: {0}", removedEdges.Count);
            foreach (var edge in removedEdges)
            {
                Console.WriteLine("{0} - {1}", edge.Item1, edge.Item2);
            }
        }

        static void RemoveCycles(Dictionary<string, List<string>> graph, List<Tuple<string, string>> removedEdges)
        {
            foreach (var node in graph)
            {
                foreach (var neighbouringNode in node.Value)
                {
                    if (!removedEdges.Any(x => x.Item1 == neighbouringNode && x.Item2 == node.Key))
                    {
                        var modifiedGraph = new Dictionary<string, List<string>>();
                        foreach (var keyValuePair in graph)
                        {
                            modifiedGraph.Add(keyValuePair.Key, keyValuePair.Value.ToArray().ToList());
                        }

                        foreach (var removedEdge in removedEdges)
                        {
                            modifiedGraph[removedEdge.Item1].Remove(removedEdge.Item2);
                            modifiedGraph[removedEdge.Item2].Remove(removedEdge.Item1);
                        }

                        modifiedGraph[node.Key].Remove(neighbouringNode);
                        modifiedGraph[neighbouringNode].Remove(node.Key);

                        if (CanFindPath(node.Key, neighbouringNode, modifiedGraph))
                        {
                            removedEdges.Add(new Tuple<string, string>(node.Key, neighbouringNode));
                        }
                    }
                }
            }
        }

        static bool CanFindPath(string startNode, string endNode, Dictionary<string, List<string>> graph)
        {
            List<List<string>> solutions = new List<List<string>>();
            Dictionary<string, bool> visited = new Dictionary<string, bool>();
            foreach (var node in graph)
            {
                visited.Add(node.Key, false);
            }
            FindPath(startNode, endNode, new List<string>(), solutions, visited, graph);
            return solutions.Count == 0 ? false : true;
        }

        static void FindPath(string node, string destination, List<string> currentSolution, List<List<string>> solutions, Dictionary<string, bool> visited, Dictionary<string, List<string>> graph)
        {
            currentSolution.Add(node);
            visited[node] = true;
            if (node == destination)
            {
                solutions.Add(currentSolution.ToArray().ToList());
                currentSolution.Remove(node);
                visited[node] = false;
                return;
            }
            foreach (var connectedNode in graph[node])
            {
                if (visited[connectedNode] == false)
                {
                    FindPath(connectedNode, destination, currentSolution, solutions, visited, graph);
                }
            }
            currentSolution.Remove(node);
            visited[node] = false;
        }
    }
}
