using System.Collections;

namespace StackOfStrings
{
    public class StackOfStrings<T> : List<T>, IEnumerable<T>
    {
        private List<T> items = new List<T>();

        public void Push(T item)
        {
            items.Add(item);
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("Stack is empty!");
            }
            T item = this.items.Last();
            items.Remove(item);
            return item;
        }

        public T Peek()
        {
            return items.Last();
        }

        public bool IsEmpty()
        {
            return items.Count == 0 ? true : false;
        }

        public new IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < items.Count; i++)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
