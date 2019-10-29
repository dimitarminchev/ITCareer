  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _71_VertexDistance
{
    class Program
    {
        static Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
        static void Main(string[] args)
        {
            int nodes = int.Parse(Console.ReadLine());
            int pathsToSearch = int.Parse(Console.ReadLine());
            for (int i = 1; i <= nodes; i++)
            {
                int[] input = Console.ReadLine().Split(new char[] {':', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                graph[input[0]] = new List<int>();
                for(int j = 1; j< input.Length; j++)
                {
                    graph[input[0]].Add(input[j]);
                }
            }

            for(int i = 1; i<= pathsToSearch; i++)
            {
                int[] path = Console.ReadLine().Split('-').Select(int.Parse).ToArray();
                int origin = path[0];
                int destination = path[1];

                Dictionary<int,bool> visited= new Dictionary<int, bool>();
                foreach(var key in graph.Keys)
                {
                    visited.Add(key, false);
                }
                List<List<int>> allSolutions = new List<List<int>>();
                FindPath(new List<int>(), allSolutions, visited, origin, destination);
                Console.WriteLine("[{0}, {1}] -> {2}", origin, destination, allSolutions.Count == 0 ? -1 : allSolutions.Min(x=>x.Count) - 1);
            }
        }

        static void FindPath(List<int> currentSolution, List<List<int>> solutions, Dictionary<int, bool> visited, int node, int destination)
        {
            currentSolution.Add(node);
            visited[node] = true;
            if(node == destination)
            {
                solutions.Add(currentSolution.ToArray().ToList());
                currentSolution.Remove(node);
                visited[node] = false;
                return;
            }
            foreach(var connectedNode in graph[node])
            {
                if(visited[connectedNode] == false)
                {
                    FindPath(currentSolution, solutions, visited, connectedNode, destination);
                }
            }
            currentSolution.Remove(node);
            visited[node] = false;
        }
    }
}
