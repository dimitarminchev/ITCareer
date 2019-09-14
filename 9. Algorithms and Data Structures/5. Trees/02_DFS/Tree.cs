using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DFS
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

        public IEnumerable<T> OrderDFS()
        {
            List<T> order = new List<T>();
            this.DFS(this, order);
            return order;
        }

        private void DFS(Tree<T> tree, List<T> order)
        {
            foreach (var child in tree.children)
                this.DFS(child, order);

            order.Add(tree.value);
        }

    }
}
