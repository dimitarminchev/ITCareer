namespace Product
{
    /// <summary>
    /// Продукт
    /// </summary>
    public class Product
    {
        private string name;
        private Product next;

        /// <summary>
        /// Конструктор
        /// </summary>
        public Product(string name, Product next = null)
        {
            this.name = name;
            this.next = next;
        }

        /// <summary>
        /// Име на продукт
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Следващ продукт
        /// </summary>
        public Product Next
        {
            get { return this.next; }
            set { this.next = value; }
        }

        public override string ToString()
        {
            return $"Product {this.name}";
        }
    }
}
