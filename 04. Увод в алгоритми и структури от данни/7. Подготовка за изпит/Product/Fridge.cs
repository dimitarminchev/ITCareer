namespace Product
{
    /// <summary>
    /// Хладилник
    /// </summary>
    public class Fridge
    {
        private Product head;
        private Product tail;
        private int count;

        /// <summary>
        /// Конструктор
        /// </summary>
        public Fridge() 
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }

        public int Count
        {
            get { return this.count; }
            private set { this.count = value; }
        }

        /// <summary>
        /// Добавяне на продукт в хладиника
        /// </summary>
        public void AddProduct(string name)
        {
            if (head == null)
            {
                // Първи продукт
                var next = new Product(name); // 1x
                head = next;
                tail = next;
            }
            else 
            {
                // Всеки следващ
                var next = new Product(name, head); // 2x
                head = next;
            }
            Count++;
        }

        /// <summary>
        /// Забъркване на манжата
        /// </summary>
        public string[] CookMeal(int start, int end)
        {
            var result = new List<string>();
            int index = 0;
            var current = head;
            while (current != null)
            {
                if (index >= start && index <= end)
                {
                    result.Add(current.Name);
                }
                index++;
                current = current.Next;
            }
            return result.ToArray();
        }

        /// <summary>
        /// Премахване на продукт по индекс
        /// </summary>
        public string RemoveProductByIndex(int index)
        {
            Product current = head;
            Product previous = null;
            int i = 0;
            while (current != null)
            {
                if (index == 0 && index == i)
                {
                    var name = head.Name;
                    head = head.Next;
                    return name; // Found
                }
                if (index == i)
                {
                    var name = current.Name;
                    previous.Next = current.Next;
                    return name; // Found
                }
                previous = current;
                current = current.Next; 
                i++;
            }
            return String.Empty; // Not Found
        }

        /// <summary>
        /// Премахване на продукт по име
        /// </summary>
        public string RemoveProductByName(string name)
        {
            Product current = head;
            int i = 0;
            while (current != null)
            {
                if (current.Name == name)
                {
                    return current.Name; // Found
                }
                current = current.Next;
                i++;
            }
            return String.Empty; // Not Found
        }

        /// <summary>
        /// Трябва да бъдат намерени всички продукти от startIndex до endInde
        /// </summary>
        public bool CheckProductIsInStock(string name)
        {
            Product current = head;
            while (current != null)
            {
                if (current.Name == name)
                {
                    return true; // Found
                }
                current = current.Next;
            }
            return false; // Not Found
        }

        /// <summary>
        /// Информация за всички продукти
        /// </summary>
        public string[] ProvideInformationAboutAllProducts()
        {
            var list = new List<string>();
            Product current = head;
            while (current != null)
            {
                list.Add(current.Name);       
                current = current.Next;
            }
            return list.ToArray();
        }
    }
}
