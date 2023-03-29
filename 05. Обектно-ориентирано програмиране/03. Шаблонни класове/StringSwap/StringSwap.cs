namespace StringSwap
{
    public class StringSwap<T>
    {
        private T[] array;
        private int index;

        public StringSwap(int capacity)
        {
            array = new T[capacity];
            index = 0;
        }

        public void Add(T item)
        {
            array[index] = item;
            index++;
        }

        public void Swap(int first, int second)
        {
            T temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }

        public void Print()
        {
            foreach (var item in array)
            {
                Console.WriteLine($"{item.GetType()}: {item}");
            }
        }
    }
}
