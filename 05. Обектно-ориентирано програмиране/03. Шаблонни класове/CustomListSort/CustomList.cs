namespace CustomListSort
{
    public class CustomList<T> where T : IComparable
    {
        private List<T> list;

        public int Count { get; private set; }

        public CustomList()
        {
            this.list = new List<T>();
            this.Count = 0;
        }

        public void Add(T element)
        {
            this.list.Add(element);
            this.Count++;
        }

        public T Remove(int index)
        {
            var element = this.list[index];
            this.list.Remove(element);
            this.Count--;
            return element;
        }

        public bool Contains(T element)
        {
            return this.list.Contains(element);
        }

        public void Swap(int index1, int index2)
        {
            var temp = this.list[index1];
            this.list[index1] = this.list[index2];
            this.list[index2] = temp;
        }

        public int CountGreaterThan(T element)
        {
            return this.list.Where(x => x.CompareTo(element) > 0).Count();
        }

        public T Max()
        {
            return this.list.Max();
        }

        public T Min()
        {
            return this.list.Min();
        }

        public void Print()
        {
            foreach (var item in this.list)
            {
                Console.WriteLine(item);
            }
        }

        public void Sort()
        {
            this.list = this.list.OrderBy(a => a).ToList();
        }

        public override string ToString()
        {
            string temp = null;
            foreach (var it in this.list)
            {
                temp += $"{it} ";
            }
            return temp;
        }
    }
}
