namespace CustomArrayList
{
    class CustomArrayList
    {
        private const int INITIAL_CAPACITY = 4;
        private object[] arr;

        private int count;
        public int Count
        {
            get { return this.count; }
            private set { this.count = value; }
        }

        private int capacity;
        public int Capacity
        {
            get { return this.capacity; }
            private set { this.capacity = value; }
        }

        public CustomArrayList(int size = INITIAL_CAPACITY)
        {
            arr = new object[size];
            capacity = size;
            count = 0;
        }

        private object this[int index]
        {
            get
            {
                OutOfRange(index);
                return this.arr[index];
            }
            set
            {
                OutOfRange(index);
                this.arr[index] = value;
                this.count++;
            }
        }

        public void Add(object item)
        {
            if (capacity == count)
            {
                capacity *= 2; // Разтягане
                object[] temp = arr;
                arr = new object[capacity];
                for (int i = 0; i < temp.Length; i++) arr[i] = temp[i];
                arr[count] = item;
            }
            else arr[count] = item;
            count++;
        }

        public object Get(int index)
        {
            OutOfRange(index);
            return arr[index];
        }

        public object Remove(int index)
        {
            OutOfRange(index);
            var temp = arr[index];
            arr = arr.Take(index).Concat(arr.Skip(index + 1)).ToArray();
            count--;
            return temp;
        }

        public void Insert(int index, object item)
        {
            OutOfRange(index);
            arr = arr.Take(index).Concat((new object[1] { item }).Concat(arr.Skip(index))).ToArray();
        }

        public void Clear()
        {
            arr = new object[capacity];
            return;
        }

        private void OutOfRange(int index)
        {
            if (index < 0 || index > count)
                throw new IndexOutOfRangeException();
        }
    }
}
