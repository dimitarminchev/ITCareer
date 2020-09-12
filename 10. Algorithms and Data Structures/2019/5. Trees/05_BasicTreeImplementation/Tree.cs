using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_BasicTreeImplementation
{
    public class Tree<T>
    {
        public T Value { get; set; }
        public Tree<T> Parent { get; private set; }
        public List<Tree<T>> Children { get; private set; }

        public Tree(T value, params Tree<T>[] children)
        {
            this.Value = value;
            if (children == null)
            {
                this.Children = new List<Tree<T>>();
            }
            else
            {
                this.Children = children.ToList();
                foreach (var child in children)
                {
                    child.Parent = this;
                }
            }
        }

        public void AddChild(Tree<T> newChild)
        {
            Children.Add(newChild);
        }
    }
}
