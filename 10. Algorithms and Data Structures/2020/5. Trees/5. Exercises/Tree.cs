using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._Exercises
{
    public class Tree
    {
        public int Value { get; private set; }
        public Tree Parent { get; private set; }
        public List<Tree> Children { get; private set; }

        public Tree(int value, params Tree[] children)
        {
            this.Value = value;
            if (children == null)
            {
                this.Children = new List<Tree>();
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

        public void AddChild(Tree child)
        {
            Children.Add(child);
        }

        public void SetParent(Tree parent)
        {
            Parent = parent;
        }

        public static void Print(Tree node, int offset = 0)
        {
            Console.WriteLine($"{new string(' ', offset * 2)}{node.Value}");
            foreach (var child in node.Children)
            {
                Print(child, offset + 1);
            }
        }
    }
}
