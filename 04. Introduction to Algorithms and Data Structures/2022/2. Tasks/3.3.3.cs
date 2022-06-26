using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _333
{
    public class Node
    {
        public int Element { get; set; }

        public Node Previous { get; set; }

        public Node(int e, Node p)
        {
            this.Element = e;
            this.Previous = p;
        }
    }

    class Program
    {

        public static Stack<int> FindSolution(Node e)
        {
            Stack<int> stack = new Stack<int>();
            while (e != null)
            {
                stack.Push(e.Element);
                e = e.Previous;
            }
            return stack;
        }

        // 3.3.3. Редица N -> M
        static void Main(string[] args)
        {
            // Input
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("m=");
            int m = int.Parse(Console.ReadLine());

            // Process
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(new Node(n,null));

            while (queue.Count > 0)
            {
                Node e = queue.Dequeue();
                if (e.Element < m)
                {
                    queue.Enqueue(new Node(e.Element + 1, e));
                    queue.Enqueue(new Node(e.Element + 2, e));
                    queue.Enqueue(new Node(e.Element * 2, e));
                }
                if (e.Element == m)
                {
                    // Solution Found
                    var stack = FindSolution(e);
                    Console.WriteLine(string.Join(" -> ", stack));
                    return;
                }
            }
            // Solution Not Found
            Console.WriteLine("No Solution");
        }
    }
}
