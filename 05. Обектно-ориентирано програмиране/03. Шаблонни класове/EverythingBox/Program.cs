using TheBox;

namespace EverythingBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Integer Box
            Box<int> box1 = new Box<int>();
            box1.Add(123);
            box1.Print();

            // String Box
            Box<string> box2 = new Box<string>();
            box2.Add("hello box");
            box2.Print();

            // Floating point Box
            Box<double> box3 = new Box<double>();
            box3.Add(3.14);
            box3.Print();
        }
    }
}