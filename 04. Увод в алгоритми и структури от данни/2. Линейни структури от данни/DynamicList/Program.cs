namespace DynamicList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new DynamicList();

            list.Add(new Node(42));
            list.Add(new Node("yes"));
            list.Add(new Node(true));

            for (int i = 0; i < list.Count; i++)
            {
                var item = ((Node)list[i]).Element.ToString();
                Console.WriteLine(item);
            }

            Console.WriteLine(list.Remove("yes"));
            Console.WriteLine(((Node)list.Remove(1)).Element.ToString());
        }

    }
}
