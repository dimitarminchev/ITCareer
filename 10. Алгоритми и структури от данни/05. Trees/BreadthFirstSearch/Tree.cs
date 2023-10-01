namespace BreadthFirstSearch
{
    /// <summary>
    /// Дървовидна структура
    /// </summary>
    /// <typeparam name="T">Тип на данните</typeparam>
    public class Tree<T>
    {
        /// <summary>
        /// Стойност на възела
        /// </summary>
        private T Value;

        /// <summary>
        /// Деца на възела
        /// </summary>
        private IList<Tree<T>> Children;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="value">Стойност на възела</param>
        /// <param name="children">Деца на възела</param>
        public Tree(T value, params Tree<T>[] children)
        {
            this.Value = value;
            this.Children = children;
        }

        /// <summary>
        /// Отпечатване на дървовидната структура
        /// </summary>
        public void Print(int indent = 0)
        {
            // Започвайки от корена
            Console.Write(new string(' ', 2 * indent));

            // Отпечатваме стойността му
            Console.WriteLine(this.Value);

            // Обхождаме всичките му деца
            foreach (var child in this.Children)
            {
                child.Print(indent + 1);
            }
        }

        /// <summary>
        /// Обхождане на дървовидната структура в широчина
        /// </summary>
        public IEnumerable<T> BFS()
        {
            List<T> order = new List<T>();

            Queue<Tree<T>> visited = new Queue<Tree<T>>();
            visited.Enqueue(this);

            while (visited.Count > 0)
            {
                var next = visited.Dequeue();
                order.Add(next.Value);
                foreach (var child in next.Children)
                {
                    visited.Enqueue(child);
                }
            }

            return order;
        }
    }
}