using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Tree
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

        public void Print(int indent = 0)
        {
            Console.Write(new string(' ', 2 * indent));
            Console.WriteLine(this.value);
            foreach (var child in this.children)
            {
                child.Print(indent + 1);
            }
        }
    }

}
