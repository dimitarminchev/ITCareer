using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3212
{
    class Program
    {
        // Hard Drive Folders
        private static Queue<string> folders = new Queue<string>();

        // Process Folder
        private static void ProcessFolder(string path)
        {
            string[] dirs = Directory.GetDirectories(path);
            foreach (var dir in dirs)
            {
                folders.Enqueue(dir);
            }
        }

        public static void Main()
        {
            // root
            ProcessFolder(@"C:\");            
    
            // level 2
            while(folders.Count > 0)
            {
                try
                {
                    var folder = folders.Dequeue();
                    Console.WriteLine(folder);
                    ProcessFolder(folder);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR: {0}", ex.Message);
                }
            }
        }
    }
}

/* 3.1 Breadth First Search Using a Queue
 BFS-B(G,s)
	for all v in V[G] do
		visited[v] := false
	end for
	Q := EmptyQueue
	visited[s] := true
	Enqueue(Q,s)
	while not Empty(Q) do
		u := Dequeue(Q)
		for all w in Adj[u] do
		if not visited[w] then
			visited[w] := true
			Enqueue(Q,w)
		end if
	end while
*/
