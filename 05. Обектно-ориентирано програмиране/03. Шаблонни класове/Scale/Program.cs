namespace Scale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Integer 
            Scale<int> intScale = new Scale<int>(32, 41);
            Console.WriteLine(intScale.GetHavier());

            // String
            Scale<string> stringScale = new Scale<string>("Ivan", "Peter");
            Console.WriteLine(stringScale.GetHavier());

            // Boolean
            Scale<bool> boolScale = new Scale<bool>(true, false);
            Console.WriteLine(boolScale.GetHavier());

            // Double
            Scale<double> doubleScale = new Scale<double>(2.34, 3.45);
            Console.WriteLine(doubleScale.GetHavier());
        }
    }
}