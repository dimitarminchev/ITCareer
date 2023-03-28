namespace CustomArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomArrayList list = new CustomArrayList();

            Console.WriteLine("Info: Count = {0}, Capacity = {1}", list.Count, list.Capacity);

            list.Add(100);
            list.Add(200);
            list.Add(300);

            Console.WriteLine("Info: Count = {0}, Capacity = {1}", list.Count, list.Capacity);

            list.Clear();
            list.Add(400);
            list.Add(500);
            list.Insert(0, 69696969);

            Console.WriteLine("Info: Count = {0}, Capacity = {1}", list.Count, list.Capacity);
        }
    }
}