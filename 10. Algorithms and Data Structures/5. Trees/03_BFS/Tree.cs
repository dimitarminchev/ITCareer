using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_BFS
{

    public class Tree<T>
    {
        private T value;
        private IList<Tree<T>> children;

        public Tree(T value, params Tree<T>[] children)
        {
            this.value = value;
            this.children = children;
        }

        public IEnumerable<T> BFS()
        {
            List<T> list = new List<T>();

            Queue<Tree<T>> queue = new Queue<Tree<T>>();
            queue.Enqueue(this);

            while (queue.Count > 0)
            {
                var next = queue.Dequeue();
                list.Add(next.value);
                foreach(var child in next.children)
                {
                    queue.Enqueue(child);
                }
            }

            return list;
        }

    }
}
