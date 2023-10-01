namespace Tree
{
    /// <summary>
    /// Дървовидна структура 
    /// </summary>
    /// <typeparam name="T">Тип на данните</typeparam>
    public class Tree<T>
    {
        // Стойност на възела
        private T Value;

        // Деца на възела
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
        /// <param name="indent">Отместване</param>
        public void Print(int indent = 0)
        {
            Console.Write(new string(' ', 2 * indent));
            Console.WriteLine(this.Value);
            foreach (var child in this.Children)
            {
                child.Print(indent + 1);
            }
        }
    }
}
