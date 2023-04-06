namespace BreadthFirstSearch
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
        /// Печат на дървото
        /// </summary>
        /// <param name="indent">Отместване</param>
        public void Print(int indent = 0)
        {
            Console.Write(new string(' ', 2 * indent));
            Console.WriteLine(this.value);
            foreach (var child in this.children)
            {
                child.Print(indent + 1);
            }
        }

        /// <summary>
        /// Ред на посещаване на възлите от дървото
        /// </summary>
        public IEnumerable<T> BFS()
        {
            List<T> order = new List<T>();
            Queue<Tree<T>> visited = new Queue<Tree<T>>();
            visited.Enqueue(this);
            while (visited.Count > 0)
            {
                var next = visited.Dequeue();
                order.Add(next.value);
                foreach (var child in next.children)
                {
                    visited.Enqueue(child);
                }
            }
            return order;
        }
    }
}
