using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Fridge
    {
        private Product head;
        private Product tail;
        private int count;

        public Fridge()
        {
            this.head = null ;
            this.tail = null;
            this.count = 0;
        }

        public int Count
        {
            get { return this.count; }
            private set { this.count = value;  }
        }

        public void AddProduct(string ProductName)
        {            
            if (this.head == null)
            {
                var next = new Product(ProductName);
                this.head = next;
                this.tail = next;
            }
            else
            {
                var next = new Product(ProductName, this.head);
                this.head = next;                
            }
            this.Count++;
        }

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

        public string RemoveProductByIndex(int index)
        {
            Product current = head;
            Product previous = null;
            int i = 0;
            while (current != null)
            {
                if (index == 0 && index == i)
                {
                    var name = this.head.Name;
                    this.head = this.head.Next;
                    return name;
                }
                if (index == i)
                {
                    var name = current.Name;
                    previous.Next = current.Next;
                    return name;
                }
                i++;
                previous = current;
                current = current.Next;
            }
            return String.Empty;
        }

        public string RemoveProductByName(string name)
        {
            Product current = head;
            Product previous = null;
            int index = 0;
            while (current != null)
            {
                if (current.Name == name)
                {
                    return RemoveProductByIndex(index);
                }
                index++;
                previous = current;
                current = current.Next;
            }
            return String.Empty;
        }

        public bool CheckProductIsInStock(string name)
        {
            var current = head;
            while (current != null)
            {
                if (current.Name == name)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public string[] ProvideInformationAboutAllProducts()
        {
            var result = new List<string>();
            var current = head;
            while (current != null)
            {
                result.Add(current.Name);
                current = current.Next;
            }
            return result.ToArray();
        }
    }
}
