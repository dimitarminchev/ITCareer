namespace DepthFirstSearch
{
    /// <summary>
    /// Дървовидна структура
    /// </summary>
    /// <typeparam name="T">Тип данни</typeparam>
    public class Tree<T>
    {
        /// <summary>
        /// Стойност на възела
        /// </summary>
        private T Value;

        /// <summary>
        /// Списък от дъщерни елементи на възела
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
        ///  Обхождане в дълбочина
        /// </summary>
        public IEnumerable<T> DFS()
        {
            List<T> order = new List<T>();
            ProcessChildren(this, order);
            return order;
        }

        private void ProcessChildren(Tree<T> tree, List<T> order)
        {
            foreach (var child in tree.Children)
            {
                ProcessChildren(child, order);
            }
            order.Add(tree.Value);
        }
    }
}