using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._CyclesBreaker
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            nodes = new Dictionary<char, List<char>>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new[] {' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                if (!nodes.ContainsKey(input[0]))
                {
                    nodes[input[0]] = new List<char>();
                }

                nodes[input[0]].AddRange(input.Skip(1).OrderBy(x=>x).ToList());
            }

            var graphs = new List<List<char>>();
            while (nodes.Any(x => !visitedAll.Contains(x.Key)))
            {
                visitedLinked = new List<char> { nodes.First(x => !visitedAll.Contains(x.Key)).Key };
                VisitLinked(visitedLinked[0]);
                graphs.Add(visitedLinked.OrderBy(x=>x).ToList());
                visitedAll.AddRange(visitedLinked.ToList());
            }

            var removed = new List<(char, char)>();
            foreach (var graph in graphs)
            {
                while(IsCycled(graph))
                {
                    for (int i = 0; i < graph.Count; i++)
                    {
                        var first = graph[i];
                        if (nodes[graph[i]].Count > 1)
                        {
                            var second = nodes[graph[i]].FirstOrDefault();
                            if (second != default(char))
                            {
                                removed.Add((first, second));
                                nodes[first].Remove(second);
                                nodes[second].Remove(first);
                                break;
                            }
                        }
                    }
                    
                }
            }
            
            Console.WriteLine($"Total removed: {removed.Count}");
            Console.WriteLine(string.Join(Environment.NewLine, removed.OrderBy(x=>x.Item1).ThenBy(x=>x.Item2).Select(x=>$"{x.Item1} - {x.Item2}")));
        }

        static List<char> visitedLinked = new List<char>();
        static List<char> visitedAll = new List<char>();
        
        static void VisitLinked(char start)
        {
            var toVisit = nodes[start].Where(x=> !visitedLinked.Contains(x));
            foreach (var node in toVisit)
            {
                visitedLinked.Add(node);
                VisitLinked(node);
            }
        }

        static bool IsCycled(List<char> graph)
        {
            currentNodes = new Dictionary<char, List<char>>();
            foreach (var node in nodes)
            {
                currentNodes.Add(node.Key, node.Value.ToList());
            }
            currentSolution = new List<char>() { graph.First()};
            visited = new List<char>() { graph.First()};
            flag = false;
            CheckCycled(graph.First(), currentNodes);
            return flag;
        }
        
        static Dictionary<char, List<char>> currentNodes;
        static List<char> currentSolution = new List<char>();
        static List<char> visited = new List<char>();
        static bool flag = false;
        static Dictionary<char, List<char>> nodes;
        
        static void CheckCycled(char start, Dictionary<char,List<char>> nodes)
        {
            if (currentSolution.Count!=currentSolution.Distinct().Count())
            {
                flag = true;
                return;
            }
            var copy = nodes[start];
            if (currentSolution.Count > 1)
            {
                copy.Remove(currentSolution[currentSolution.Count - 2]);
            }
            var toVisit = copy.ToList();
            foreach (var node in toVisit)
            {
                visited.Add(node);
                currentSolution.Add(node);
                CheckCycled(node, nodes);
                currentSolution.Remove(node);
                visited.Remove(node);
            }
        }
    }
}
