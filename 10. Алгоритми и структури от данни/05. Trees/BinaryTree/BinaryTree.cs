namespace BinaryTree
{
    /// <summary>
    /// Структура от тип двоично дърво
    /// </summary>
    /// <typeparam name="T">Тип данни на структурата</typeparam>
    public class BinaryTree<T> where T : IComparable<T>
    {
        // Корен
        public BinaryNode<T> Root { get; set; }

        // Брой елементи
        public int Count { get; private set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        public BinaryTree()
        {
            this.Root = null;
            this.Count = 0;
        }

        /// <summary>
        /// Добавяне
        /// </summary>
        public void Add(T item)
        {
            BinaryNode<T> node = new BinaryNode<T>(item);

            if (Root == null)
            {
                Root = node;
                return;
            }

            BinaryNode<T> it = Root;
            while (true)
            {
                if (it.Left != null && it.Item.CompareTo(item) >= 0) it = it.Left;
                else if (it.Right != null && it.Item.CompareTo(item) < 0) it = it.Right;
                else break;
            }

            if (it.Item.CompareTo(item) >= 0) it.Left = node;
            else if (it.Item.CompareTo(item) < 0) it.Right = node;
            this.Count++;
        }


        /// <summary>
        /// Съдържа ли се 
        /// </summary>
        public bool Contains(T item)
        {
            if (Root == null) return false;

            BinaryNode<T> it = Root;
            while (true)
            {
                if (it == null) return false;
                else if (it.Item.CompareTo(item) == 0) return true;
                else if (it.Item.CompareTo(item) > 0) it = it.Left;
                else if (it.Item.CompareTo(item) < 0) it = it.Right;
            }

        }

        /// <summary>
        /// Премахване
        /// </summary>
        public void Remove(T item)
        {
            // TODO: Remove

            // if node == null -> изход
            // else if x is leaf -> премахни
            // else if x is not leaf -> подмени

            // 1. Премахване на елемент, който няма дясно поддърво:
            // 1.1. Намираме елемента за премахване
            // 1.2 Корена на лявото поддърво заема мястото на премахнатия елемент

            // 2. Премахване на елемент, чието дясно поддърво няма ляво поддърво
            // 2.1. Намираме елемента за премахване
            // 2.2. Корена на дясното поддърво заема мястото на премахнатия елемент

            // 3. Премахване на елемент, който има и ляво и дясно поддърво
            // 3.1. Намираме елемента за премахване
            // 3.2. Намираме най-малкия елемент в лявото разклонение на дясното му поддърво
            // 3.3. Разменяме двата елемента и извършваме премахването
        }
    }
}