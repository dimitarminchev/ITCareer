namespace _01._MathOperation
{
    public class Program
    {
        static void Main(string[] args)
        {
            MathOperation mo = new MathOperation();
            Console.WriteLine(mo.Add(2,3)); // 5
            Console.WriteLine(mo.Add(2.2, 3.3, 5.5)); // 11
            Console.WriteLine(mo.Add(2.2m, 3.3m, 4.4m)); // 9.9
        }
    }
}