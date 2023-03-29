namespace Threeuple
{
    public class Threeuple<T, U, V>
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

        private V item3;

        public V Item3
        {
            get { return item3; }
            set { item3 = value; }
        }

        public Threeuple(T item1 = default(T), U item2 = default(U), V item3 = default(V))
        {
            this.Item1 = item1;
            this.Item2 = item2;
            this.Item3 = item3;
        }

        public override string ToString()
        {
            return $"{this.Item1} -> {this.Item2} -> {this.Item3}";
        }
    }
}
