namespace _01_TheBox
{
    /// <summary>
    /// The Box
    /// </summary>
    public class Box<T>
    {
        private List<T> data;

        /// <summary>
        /// Constructor
        /// </summary>
        public Box()
        {
            this.data = new List<T>();
        }

        /// <summary>
        /// Count
        /// </summary>
        public int Count => this.data.Count;

        /// <summary>
        /// Add
        /// </summary>
        public void Add(T item)
        {
            this.data.Add(item);
        }

        /// <summary>
        /// Remove
        /// </summary>
        public T Remove()
        {
            T temp = this.data.Last();
            this.data.RemoveAt(this.data.Count - 1);
            return temp;
        }
    }
}
