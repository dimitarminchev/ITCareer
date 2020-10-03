using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._GraphCycle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            nodes = new Dictionary<char, List<char>>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split('-').Select(char.Parse).ToArray();
                if (!nodes.ContainsKey(input[0]))
                {
                    nodes[input[0]] = new List<char>();
                }
                if (!nodes.ContainsKey(input[1]))
                {
                    nodes[input[1]] = new List<char>();
                }
                nodes[input[0]].Add(input[1]);
                nodes[input[1]].Add(input[0]);
            }

            currentSolution.Add(nodes.First().Key);
            visited.Add(nodes.First().Key);
            Solve(nodes.First().Key);
            var cycled = flag ? "Yes" : "No";
            Console.WriteLine($"Cycled: {cycled}");
        }

        static List<char> currentSolution = new List<char>();
        static List<char> visited = new List<char>();
        static bool flag = false;
        static Dictionary<char, List<char>> nodes;

        static void Solve(char start)
        {
            if (currentSolution.Count != currentSolution.Distinct().Count())
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
                Solve(node);
                currentSolution.Remove(node);
                visited.Remove(node);
            }
        }
    }
}