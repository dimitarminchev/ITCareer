using System.Collections;

namespace ArrayList
{
    /// <summary>
    /// Структура от тип разтеглив масив
    /// </summary>
    /// <typeparam name="T">Тип данни</typeparam>
    public class ArrayList<T> : IEnumerable<T>
    {
        // Масив
        private T[] items;

        /// <summary>
        /// Брой на елементите
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// Капацитет
        /// </summary>
        public int Capacity { get; private set; }

        /// <summary>
        /// Конструкотр
        /// </summary>
        public ArrayList()
        {
            this.Count = 0;
            this.Capacity = 2;
            this.items = new T[this.Capacity];
        }

        /// <summary>
        /// Достъпване на елемент по индекс
        /// </summary>
        public T this[int index] 
        {
            get
            {
                OutOfRange(index);
                return items[index];
            }
            set 
            {
                OutOfRange(index);
                this.items[index] = value;
            }
        }

        /// <summary>
        /// Добавяне на елемент към структурата
        /// </summary>
        /// <param name="item">Елемент за добавяне</param>
        public void Add(T item)
        {
            // Разширяване
            if (this.Count == this.Capacity)
            {
                this.Capacity *= 2;
                var temp = this.items;
                this.items = new T[this.Capacity];
                for (int i = 0; i < temp.Count(); i++)
                {
                    this.items[i] = temp[i];
                }
            }
            this.items[this.Count] = item;
            this.Count++;
        }

        /// <summary>
        /// Преоразмеряване на структурата
        /// </summary>
        public void Resize()
        {
            // Създаваме 2 по-голям масив
            T[] copy = new T[this.items.Length * 2];

            // Копираме досегашните елемнти в нови
            for (int i = 0; i < this.items.Length; i++)
            {
                copy[i] = this.items[i];
            }

            // Заменяме стария с новия масив
            this.items = copy;
        }

        /// <summary>
        /// Премахва елемент от стуктурата
        /// </summary>
        /// <param name="index">Индекс на елемента</param>
        /// <returns>Връща елемента</returns>
        /// <exception cref="ArgumentOutOfRangeException">Извън обхват</exception>
        public T RemoveAt(int index)
        {
            // Проверка дали сме в границите
            OutOfRange(index);

            var item = this.items[index];
            this.items = items.Take(index).Concat(items.Skip(index + 1)).Concat(new T[1]).ToArray();
            this.Count--;

            // Свиване
            if (this.items.Count() <= this.Capacity / 2)
            {
                if (this.Count < 2) return item;
                this.Capacity /= 2;
                var temp = this.items;
                this.items = new T[this.Capacity];
                for (int i = 0; i < temp.Count(); i++)
                {
                    this.items[i] = temp[i];
                }
            }

            return item;
        }

        // Проверка дали сме в границите
        private void OutOfRange(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new IndexOutOfRangeException();
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.items.Count(); i++)
            {
                yield return this.items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
