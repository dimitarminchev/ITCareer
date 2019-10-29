using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new DynamicList();

            // Добавяме
            list.Add(new Node(42));
            list.Add(new Node("yes"));
            list.Add(new Node(true));

            // Печат
            for (int i = 0; i < list.Count; i++)
            {
                var item = ((Node)list[i]).Element.ToString();
                Console.WriteLine(item);
            }

            // Премахване
            Console.WriteLine(list.Remove("yes"));
            Console.WriteLine(((Node)list.Remove(1)).Element.ToString());
        }
    }
}
