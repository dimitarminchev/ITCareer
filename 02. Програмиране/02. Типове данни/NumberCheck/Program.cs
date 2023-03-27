namespace NumberCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var value = Console.ReadLine();

            float f;
            int i;

            if (int.TryParse(value, out i))
            {
                Console.WriteLine("integer");
            }
            else if (float.TryParse(value, out f))
            {
                Console.WriteLine("floating-point");
            }
        }
    }
}