namespace _06_Scale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Integer 
            Scale<int> intScale = new Scale<int>(32, 41);
            Console.WriteLine(intScale.GetHavier());

            // 2. String
            Scale<string> stringScale = new Scale<string>("Ivan", "Peter");
            Console.WriteLine(stringScale.GetHavier());

            // 3. Boolean
            Scale<bool> boolScale = new Scale<bool>(true, false);
            Console.WriteLine(boolScale.GetHavier());

            // 4. Double
            Scale<double> doubleScale = new Scale<double>(2.34, 3.45);
            Console.WriteLine(doubleScale.GetHavier());
        }
    }
}