namespace SequenceNM
{
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

        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("m=");
            int m = int.Parse(Console.ReadLine());

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(new Node(n, null));

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
                    var stack = FindSolution(e);
                    Console.WriteLine(string.Join(" -> ", stack));
                    return;
                }
            }

            Console.WriteLine("No Solution");
        }
    }
}