namespace _01_TheBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<int> box = new Box<int>();
            box.Add(1);
            box.Add(2);
            box.Add(3);
            Console.WriteLine(box.Remove()); // 3 
            box.Add(4);
            box.Add(5);
            Console.WriteLine(box.Remove()); // 5
        }
    }
}