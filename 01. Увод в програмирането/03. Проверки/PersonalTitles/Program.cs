namespace PersonalTitles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            var sex = Console.ReadLine();
            if (sex == "f")
            {
                if (age < 16) Console.WriteLine("Miss");
                else Console.WriteLine("Ms.");
            }
            else
            {
                if (age < 16) Console.WriteLine("Master");
                else Console.WriteLine("Mr.");
            }
        }
    }
}