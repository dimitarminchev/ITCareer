namespace Tuple
{
    public class Tuple<T, U>
    {
        private T item1;

        public T Item1
        {
            get { return item1; }
            set { item1 = value; }
        }

        private U item2;

        public U Item2
        {
            get { return item2; }
            set { item2 = value; }
        }

        public Tuple(T item1 = default(T), U item2 = default(U))
        {
            this.Item1 = item1;
            this.Item2 = item2;
        }

        public override string ToString()
        {
            return $"{this.Item1} -> {this.Item2}";
        }
    }
}
