using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace _1._Tree
{
    /// <summary>
    /// Дървовидна структура
    /// </summary>
    /// <typeparam name="T">Тип на данните</typeparam>
    public class Tree<T>
    {
        // Стойност на възела
        private T value;

        // Деца на възела
        private IList<Tree<T>> children;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="value">Стойност на възела</param>
        /// <param name="children">Деца на възела</param>
        public Tree(T value, params Tree<T>[] children)
        {
            this.value = value;
            this.children = children;
        }

        /// <summary>
        /// Печат на вървото
        /// </summary>
        /// <param name="indent">Отместване</param>
        public void Print(int indent = 0)
        {
            Console.Write(new string(' ', 2*indent));
            Console.WriteLine(this.value);
            foreach (var child in this.children)
            {
                child.Print(indent + 1);
            }
        }
    }
}
